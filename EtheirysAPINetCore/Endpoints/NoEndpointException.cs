using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EtheirysAPINetCore.Endpoints
{
    public class NoEndpointException : Exception
    {
        public NoEndpointException() : base("There is no valid endpoint for type. Did you forget the EndpointAttribute?")
        {
        }
    }
}
