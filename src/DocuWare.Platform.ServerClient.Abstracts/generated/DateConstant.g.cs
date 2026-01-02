using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DateConstant(DocuWare.Platform.ServerClient.DateConstant obj) : IDateConstant
    {
        internal DocuWare.Platform.ServerClient.DateConstant Obj { get; } = obj;

        public DateTime? Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
