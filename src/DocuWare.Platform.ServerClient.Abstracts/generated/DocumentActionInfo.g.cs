using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentActionInfo(SDK.DocumentActionInfo obj) : IDocumentActionInfo
    {
        internal SDK.DocumentActionInfo Obj { get; } = obj;

        public IDocumentActionParameters DocumentActionParameters
        {
            get => new DocumentActionParameters(Obj.DocumentActionParameters);
            set => Obj.DocumentActionParameters = ((DocumentActionParameters)value).Obj;
        }

        public DocuWare.Platform.ServerClient.DocumentAction DocumentAction
        {
            get => Obj.DocumentAction;
            set => Obj.DocumentAction = value;
        }
    }
}
