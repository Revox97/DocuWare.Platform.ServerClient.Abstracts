using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateDocumentsSource(SDK.BatchUpdateDocumentsSource obj) : IBatchUpdateDocumentsSource
    {
        internal SDK.BatchUpdateDocumentsSource Obj { get; } = obj;

		public List<int> Id
		{
			get => Obj.Id;
			set => Obj.Id = value;
		}
    }
}
