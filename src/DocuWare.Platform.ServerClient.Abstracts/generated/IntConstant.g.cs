using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntConstant(SDK.IntConstant obj) : IIntConstant
    {
        internal SDK.IntConstant Obj { get; } = obj;

        public int? Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
