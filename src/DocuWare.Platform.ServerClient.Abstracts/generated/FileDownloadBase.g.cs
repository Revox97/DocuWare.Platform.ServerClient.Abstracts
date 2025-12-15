using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileDownloadBase(SDK.FileDownloadBase obj) : IFileDownloadBase
    {
        internal SDK.FileDownloadBase Obj { get; } = obj;

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
