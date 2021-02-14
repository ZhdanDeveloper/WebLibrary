namespace WebLibrary_API.Responses
{
    public class APINotFoundResponse : APIResponse
    {
        public APINotFoundResponse(string[] errormessage = default) : base(false, 404, null, errormessage, null)
        { }
    }
}