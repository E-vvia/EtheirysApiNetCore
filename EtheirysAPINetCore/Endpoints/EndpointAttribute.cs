using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtheirysAPINetCore.Endpoints
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class EndpointAttribute : Attribute
    {
        internal string Endpoint { get; }
        
        internal EndpointAttribute(string endpoint)
        {
            Endpoint = endpoint;
        }
    }
}
