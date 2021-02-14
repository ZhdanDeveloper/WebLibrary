namespace WebLibrary_API.Responses
{
    public class APIBadRequestResponse : APIResponse
    {
        public APIBadRequestResponse(string [] errormessage = default) : base(false, 400, null, errormessage, null)
        { }
    }
}