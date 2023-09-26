namespace User.Application.DTOs.Responses
{
    public class ApiResponse<T>
    {
        public ApiResponse(bool success, T result, int statusCode, IEnumerable<string> errors = null)
        {
            Success = success;
            Result = result;
            StatusCode = statusCode;
            Errors = errors ?? new List<string>();
        }

        public bool Success { get; set; }
        public T Result { get; set; }
        public int StatusCode { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
