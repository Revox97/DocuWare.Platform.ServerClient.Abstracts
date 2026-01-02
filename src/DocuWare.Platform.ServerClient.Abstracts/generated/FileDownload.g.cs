using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileDownload(DocuWare.Platform.ServerClient.FileDownload obj) : IFileDownload
    {
        internal DocuWare.Platform.ServerClient.FileDownload Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.FileDownloadType TargetFileType
        {
            get => Obj.TargetFileType;
            set => Obj.TargetFileType = value;
        }

        public bool DirectDownload
        {
            get => Obj.DirectDownload;
            set => Obj.DirectDownload = value;
        }

        public bool AutoPrint
        {
            get => Obj.AutoPrint;
            set => Obj.AutoPrint = value;
        }

        public bool SendByEmail
        {
            get => Obj.SendByEmail;
            set => Obj.SendByEmail = value;
        }

        public bool Fillable
        {
            get => Obj.Fillable;
            set => Obj.Fillable = value;
        }

        public List<int> Layers
        {
            get => Obj.Layers;
            set => Obj.Layers = value;
        }

        public bool KeepAnnotations
        {
            get => Obj.KeepAnnotations;
            set => Obj.KeepAnnotations = value;
        }
    }
}
