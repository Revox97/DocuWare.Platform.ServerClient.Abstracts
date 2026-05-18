using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AttachFileInfo(SDK.AttachFileInfo obj) : IAttachFileInfo
    {
        internal SDK.AttachFileInfo Obj { get; } = obj;

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string FormattedSize
        {
            get => Obj.FormattedSize;
            set => Obj.FormattedSize = value;
        }

        public FileSource Source
        {
            get => (FileSource)Obj.Source;
            set => Obj.Source = (DocuWare.Platform.ServerClient.FileSource)value;
        }
    }
}
