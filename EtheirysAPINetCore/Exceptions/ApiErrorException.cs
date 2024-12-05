using EtheirysAPINetCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtheirysAPINetCore.Exceptions
{
    public class ApiErrorException : Exception
    {
        private const string ERROR_MSG = "Error processing the API request. Check Details for more information.";
        public ProblemDetails? Details { get; set; }
        internal ApiErrorException(ProblemDetails? details) : base(ERROR_MSG)
        {
            Details = details;
        }

        internal ApiErrorException(ProblemDetails? details, Exception innerException) : base(ERROR_MSG, innerException)
        {
            Details = details;
        }
    }
}
