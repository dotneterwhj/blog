using System;
using System.Collections.Generic;
using System.Text;

namespace Nextload.Blog.ToolKits
{
    public class ServiceResult
    {
        public ServiceResultCode Code { get; set; }

        public string Message { get; set; }

        public bool Success => Code == ServiceResultCode.Successed;

        public long Timestamp { get; } = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;

        public void IsSuccess(string message = "")
        {
            Message = message;
            Code = ServiceResultCode.Successed;
        }

        public void IsFail(string message = "")
        {
            Message = message;
            Code = ServiceResultCode.Failed;
        }

        public void IsFail(Exception exception)
        {
            Message = exception.InnerException?.StackTrace;
            Code = ServiceResultCode.Failed;
        }

    }
}
