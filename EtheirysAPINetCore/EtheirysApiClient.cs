using EtheirysAPINetCore.Endpoints;
using EtheirysAPINetCore.Exceptions;
using EtheirysAPINetCore.Model;
using EtheirysAPINetCore.Parameters;
using System.Reflection;
using System.Text.Json;

namespace EtheirysAPINetCore
{
    public class EtheirysApiClient : IDisposable
    {
        private readonly Uri API_ENDPOINT = new("https://etheirysapi.com/api/");
        private readonly HttpClient httpClient;
        private readonly JsonSerializerOptions serializerOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public EtheirysApiClient()
        {
            httpClient = new HttpClient
            {
                BaseAddress = API_ENDPOINT
            };
        }

        public EtheirysApiClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.httpClient.BaseAddress = API_ENDPOINT;
        }

        public async Task<Paginated<T>> GetPaginatedAsync<T>(PaginationRequest<T> request) where T : Entity
        {
            string parameters = request.GenerateRequest();
            string endpoint = $"{GetEndpoint<T>()}?{parameters}";
            return await SendRequestAsync<Paginated<T>>(endpoint);
        }

        public async Task<T> GetAsync<T>(int id) where T : Entity
        {
            string endpoint = $"{GetEndpoint<T>()}/{id}";
            return await SendRequestAsync<T>(endpoint);
        }

        private async Task<T> SendRequestAsync<T>(string endpoint)
        {
            using HttpResponseMessage response = await httpClient.GetAsync(endpoint);
            string content = await response.Content.ReadAsStringAsync();

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                ProblemDetails? details = JsonSerializer.Deserialize<ProblemDetails>(content, serializerOptions);
                throw new ApiErrorException(details, ex);
            }

            return JsonSerializer.Deserialize<T>(content, serializerOptions) ?? throw new InvalidDataException("Deserialized value is null");
        }

        private static string GetEndpoint<T>()
        {
            return typeof(T).GetCustomAttribute<EndpointAttribute>()?.Endpoint ?? throw new NoEndpointException();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && httpClient != null)
            {
                httpClient.Dispose();
            }
        }

        ~EtheirysApiClient()
        {
            Dispose(false);
        }
    }
}
