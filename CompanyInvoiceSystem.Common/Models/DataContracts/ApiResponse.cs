using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CompanyInvoiceSystem.Common.Models.Api
{
    [DataContract]
    public class ApiResponse
    {
        [DataMember]
        public ErrorCode ApiStatusCode { get; set; }

        [DataMember]
        public HttpStatusCode HttpStatusCode { get; set; }

        [DataMember]
        public string ApiStatusMessage { get; set; }

        [DataMember]
        public ApiExceptionDetails ExceptionDetails { get; set; }

        public bool Error
        {
            get { return ExceptionDetails != null; }
        }
    }
}
