namespace X.Application.ViewModel.Common
{
    public class ApiResult<T>
    {
        public bool isSuccessed { get; set; }
        public string Message { get; set; } = string.Empty;
        public T ResultObject { get; set; }
    }
}