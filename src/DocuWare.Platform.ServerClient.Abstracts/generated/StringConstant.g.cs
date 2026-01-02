using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StringConstant(DocuWare.Platform.ServerClient.StringConstant obj) : IStringConstant
    {
        internal DocuWare.Platform.ServerClient.StringConstant Obj { get; } = obj;

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
