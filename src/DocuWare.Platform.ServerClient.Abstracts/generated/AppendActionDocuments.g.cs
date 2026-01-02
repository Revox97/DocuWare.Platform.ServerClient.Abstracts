using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AppendActionDocuments(DocuWare.Platform.ServerClient.AppendActionDocuments obj) : IAppendActionDocuments
    {
        internal DocuWare.Platform.ServerClient.AppendActionDocuments Obj { get; } = obj;

        public List<int> Documents
        {
            get => Obj.Documents;
            set => Obj.Documents = value;
        }
    }
}
