using System;
using System.Runtime.Serialization;

namespace CompanyInvoiceSystem.Common.Models.Api
{
    [DataContract]
    public class ApiExceptionDetails
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string StackTrace { get; set; }

        [DataMember]
        public ApiExceptionDetails InnerException { get; set; }

        public ApiExceptionDetails(Exception ex)
        {
            if (ex == null)
                return;
            Message = ex.Message;
            Type = ex.GetType().ToString();
            StackTrace = ex.StackTrace;
            if (ex.InnerException != null)
                InnerException = new ApiExceptionDetails(ex.InnerException);
        }
    }
}