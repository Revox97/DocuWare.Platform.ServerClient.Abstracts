using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentVersion(DocuWare.Platform.ServerClient.DocumentVersion obj) : IDocumentVersion
    {
        internal DocuWare.Platform.ServerClient.DocumentVersion Obj { get; } = obj;

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
