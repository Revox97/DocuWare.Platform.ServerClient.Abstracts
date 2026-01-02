using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntConstant(DocuWare.Platform.ServerClient.IntConstant obj) : IIntConstant
    {
        internal DocuWare.Platform.ServerClient.IntConstant Obj { get; } = obj;

        public int? Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }
    }
}
