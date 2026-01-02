using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Rights(DocuWare.Platform.ServerClient.Rights obj) : IRights
    {
        internal DocuWare.Platform.ServerClient.Rights Obj { get; } = obj;

        public List<DocuWare.Platform.ServerClient.Right> Right
        {
            get => Obj.Right;
            set => Obj.Right = value;
        }
    }
}
