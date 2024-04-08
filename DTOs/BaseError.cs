namespace Waffar.DTOs
{
    public class BaseError<T>
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }

    }
}
