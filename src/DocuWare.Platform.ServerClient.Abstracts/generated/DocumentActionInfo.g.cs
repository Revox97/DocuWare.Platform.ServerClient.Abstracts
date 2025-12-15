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

		public DocumentAction DocumentAction
		{
			get => new ocumentAction(Obj.DocumentAction);
			set => Obj.DocumentAction = ((ocumentAction)value).Obj;
		}
    }
}
