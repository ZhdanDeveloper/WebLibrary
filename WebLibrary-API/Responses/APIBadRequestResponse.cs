using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLibrary_API.Responses
{
    public class APIBadRequestResponse : ApiResponse
    {
        public APIBadRequestResponse(string [] errormessage = default) : base(false, 400, null, errormessage, null)
        { }
    }
}
