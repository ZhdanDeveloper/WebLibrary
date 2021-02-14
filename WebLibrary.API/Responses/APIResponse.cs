using System;
namespace WebLibrary_API.Responses
{
    public class APIResponse
    {
        public APIResponse(bool oK, int statusCode, string message, string[] errors, object data)
        {
            OK = oK;
            StatusCode = statusCode;
            Message = message;
            Errors = errors;
            Data = data;
        }

        public bool OK { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string [] Errors { get; set; }
        public DateTime TimeSpan { get; set; } = DateTime.UtcNow;
        public object Data { get; set; }
    }
}