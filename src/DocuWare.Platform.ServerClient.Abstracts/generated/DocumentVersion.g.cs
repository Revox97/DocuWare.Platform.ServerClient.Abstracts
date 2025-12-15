using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentVersion(SDK.DocumentVersion obj) : IDocumentVersion
    {
        internal SDK.DocumentVersion Obj { get; } = obj;

        public int Major
        {
            get => Obj.Major;
            set => Obj.Major = value;
        }

        public int Minor
        {
            get => Obj.Minor;
            set => Obj.Minor = value;
        }
    }
}
