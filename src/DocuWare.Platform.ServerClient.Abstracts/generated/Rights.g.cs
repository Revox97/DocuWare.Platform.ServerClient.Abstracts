using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Rights(SDK.Rights obj) : IRights
    {
        internal SDK.Rights Obj { get; } = obj;

        public List<DocuWare.Platform.ServerClient.Right> Right
        {
            get => Obj.Right;
            set => Obj.Right = value;
        }
    }
}
