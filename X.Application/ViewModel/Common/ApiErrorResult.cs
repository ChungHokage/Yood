namespace X.Application.ViewModel.Common
{
    public class ApiErrorResult<T> : ApiResult<T>
    {
        public string[] ValidationErrors { get; set; }

        public ApiErrorResult()
        {
        }

        public ApiErrorResult(string message)
        {
            isSuccessed = false;
            Message = message;
        }

        public ApiErrorResult(string[] validationErrors)
        {
            isSuccessed = false;
            ValidationErrors = validationErrors;
        }
    }
}