using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentsTransferInfo(SDK.DocumentsTransferInfo obj) : IDocumentsTransferInfo
    {
        internal SDK.DocumentsTransferInfo Obj { get; } = obj;

        public List<IDocument> Documents
        {
            get => Obj.Documents.Select(x => new Document(x) as IDocument).ToList();
            set => Obj.Documents = value.Select(x => ((Document)x).Obj).ToList();
        }

        public string SourceFileCabinetId
        {
            get => Obj.SourceFileCabinetId;
            set => Obj.SourceFileCabinetId = value;
        }

        public bool UseDefaultDialog
        {
            get => Obj.UseDefaultDialog;
            set => Obj.UseDefaultDialog = value;
        }

        public bool KeepSource
        {
            get => Obj.KeepSource;
            set => Obj.KeepSource = value;
        }

        public bool FillIntellix
        {
            get => Obj.FillIntellix;
            set => Obj.FillIntellix = value;
        }

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
