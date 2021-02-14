namespace WebLibrary_API.Responses
{
    public class APIOKResponse : APIResponse
    {
        public APIOKResponse(object Data = null, string Message = "Success") : base(true, 200, Message, null, Data)
        {

        }
    }
}