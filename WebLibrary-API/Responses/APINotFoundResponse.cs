using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLibrary_API.Responses
{
    public class APINotFoundResponse : ApiResponse
    {
        public APINotFoundResponse(string[] errormessage = default) : base(false, 404, null, errormessage, null)
        { }
    }
}
