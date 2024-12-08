using System;
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
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in GetType().GetProperties())
            {
                if (property.PropertyType == typeof(Type))
                {
                    continue;
                }
                object? value = property.GetValue(this);

                if (property.PropertyType.IsArray)
                {
                    Array arr = value as Array ?? Array.Empty<object>();

                    foreach (object arrValue in arr)
                    {
                        sb.Append(property.Name);
                        sb.Append('=');
                        sb.Append(arrValue.ToString());
                        sb.Append('&');
                    }
                }
                else
                {
                    if (value != null)
                    {
                        sb.Append(property.Name);
                        sb.Append('=');
                        sb.Append(property.GetValue(this)?.ToString());
                        sb.Append('&');
                    }
                }
            }

            sb.Length--;

            return sb.ToString();
        }
    }
}
