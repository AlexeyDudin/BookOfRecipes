namespace WebAPI.Dto.Response
{
    public class Result
    {
        public object Content { get; }
        public ResponseStatus Status { get; }

        public Result(object content, ResponseStatus status)
        {
            Content = content;
            Status = status;
        }
    }
}
