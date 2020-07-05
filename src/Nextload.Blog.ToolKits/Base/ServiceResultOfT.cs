using System;
using System.Collections.Generic;
using System.Text;

namespace Nextload.Blog.ToolKits
{
    public class ServiceResult<T> : ServiceResult where T : class
    {
        public T Result { get; set; }

        public void IsSuccess(T result = null, string message = "")
        {
            Result = result; 
            Message = message;
            Code = ServiceResultCode.Successed;
        }
    }
}
