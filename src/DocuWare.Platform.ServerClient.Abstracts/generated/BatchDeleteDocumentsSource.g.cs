using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchDeleteDocumentsSource(SDK.BatchDeleteDocumentsSource obj) : IBatchDeleteDocumentsSource
    {
        internal SDK.BatchDeleteDocumentsSource Obj { get; } = obj;

		public List<string> Id
		{
			get => Obj.Id;
			set => Obj.Id = value;
		}
    }
}
