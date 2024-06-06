namespace X.Application.ViewModel.Common
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T resultObj, string message)
        {
            isSuccessed = true;
            ResultObject = resultObj;
            Message = message;
        }

        public ApiSuccessResult()
        {
            isSuccessed = true;
        }

        public ApiSuccessResult(string mesg)
        {
            isSuccessed = true;
            Message = mesg;
        }
    }
}