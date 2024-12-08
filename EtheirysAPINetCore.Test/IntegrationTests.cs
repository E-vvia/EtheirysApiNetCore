using EtheirysAPINetCore.Model;
using EtheirysAPINetCore.Model.ClassJobs;
using EtheirysAPINetCore.Parameters;

namespace EtheirysAPINetCore.Test
{
    public class IntegrationTests
    {
        private readonly EtheirysApiClient apiClient;
        public IntegrationTests()
        {
            apiClient = new EtheirysApiClient();
        }

        [Fact]
        public async Task GetClassJobByID()
        {
            Assert.NotEqual(default, await DoRequestById<ClassJob>(1));
        }

        [Fact]
        public async Task GetPaginatedClassJobs()
        {
            Assert.NotEqual(default, await DoPaginatedRequest(new ClassJobRequest()
            {
                Abbreviation = "WAR",
            }));
        }

        [Fact]
        public async Task GetRequestWithArray()
        {
            Assert.NotEqual(default, await DoPaginatedRequest(new ItemRequest()
            {
                Type = [ItemRequest.ItemTypes.Gear, ItemRequest.ItemTypes.MedicineMeal]
            }));
        }

        private async Task<T> DoRequestById<T>(int id) where T : Entity {
            return await apiClient.GetAsync<T>(id);
        }

        private async Task<Paginated<T>> DoPaginatedRequest<T>(PaginationRequest<T> request) where T : Entity
        {
            return await apiClient.GetPaginatedAsync(request);
        }
    }
}