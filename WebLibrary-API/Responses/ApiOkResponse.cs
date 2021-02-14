using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLibrary_API.Responses
{
    public class ApiOkResponse : ApiResponse
    {
        public ApiOkResponse(object Data = null, string Message = "Success") : base(true, 200, Message, null, Data)
        {

        }
    }
}
