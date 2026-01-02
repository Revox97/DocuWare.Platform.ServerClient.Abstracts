using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DateTimeConstant(DocuWare.Platform.ServerClient.DateTimeConstant obj) : IDateTimeConstant
    {
        internal DocuWare.Platform.ServerClient.DateTimeConstant Obj { get; } = obj;

        public DateTime? Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
