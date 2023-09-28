namespace Domain.Models
{
    public class ApiResponse<T>
    {
        public ApiResponse(int statusCode, T result)
        {
            Success = true;
            StatusCode = statusCode;
            Result = result;
        }

        public ApiResponse(int statusCode, IEnumerable<string> errors = null)
        {
            Success = false;
            StatusCode = statusCode;
            Errors = errors;
        }

        public bool Success { get; set; }
        public T Result { get; set; }
        public int StatusCode { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
