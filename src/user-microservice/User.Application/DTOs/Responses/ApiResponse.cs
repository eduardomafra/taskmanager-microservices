namespace User.Application.DTOs.Responses
{
    public class ApiResponse<T>
    {
        public ApiResponse(bool success, int statusCode, T result, IEnumerable<string> errors = null)
        {
            Success = success;
            StatusCode = statusCode;
            Result = result;            
            Errors = errors;
        }

        public bool Success { get; set; }
        public T Result { get; set; }
        public int StatusCode { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
