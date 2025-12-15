using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetTransferInfo(SDK.FileCabinetTransferInfo obj) : IFileCabinetTransferInfo
    {
        internal SDK.FileCabinetTransferInfo Obj { get; } = obj;

        public List<int> SourceDocId
        {
            get => Obj.SourceDocId;
            set => Obj.SourceDocId = value;
        }

        public string SourceFileCabinetId
        {
            get => Obj.SourceFileCabinetId;
            set => Obj.SourceFileCabinetId = value;
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
    }
}
