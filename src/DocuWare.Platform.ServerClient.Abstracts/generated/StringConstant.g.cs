using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StringConstant(SDK.StringConstant obj) : IStringConstant
    {
        internal SDK.StringConstant Obj { get; } = obj;

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
