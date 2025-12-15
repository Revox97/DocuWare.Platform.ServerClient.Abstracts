using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AppendActionDocuments(SDK.AppendActionDocuments obj) : IAppendActionDocuments
    {
        internal SDK.AppendActionDocuments Obj { get; } = obj;

		public string SourceCabinetId
		{
			get => Obj.SourceCabinetId;
			set => Obj.SourceCabinetId = value;
		}

		public List<int> Documents
		{
			get => Obj.Documents;
			set => Obj.Documents = value;
		}
    }
}
