using EtheirysAPINetCore.Model.Items;
using System.Reflection;
using System.Text;

namespace EtheirysAPINetCore.Parameters
{
    public abstract class PaginationRequest<T>
    {
        public Type ResponseDataType => typeof(T);
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        internal string GenerateRequest()
        {
            StringBuilder sb = new();
            foreach (PropertyInfo property in GetType().GetProperties())
            {
                if (property.PropertyType == typeof(Type))
                {
                    continue;
                }

                object? value = property.GetValue(this);

                if (value != null)
                {
                    sb.Append(property.Name);
                    sb.Append('=');
                    sb.Append(property.GetValue(this)?.ToString());
                    sb.Append('&');
                }
            }

            sb.Length--;

            return sb.ToString();
        }
    }
}
