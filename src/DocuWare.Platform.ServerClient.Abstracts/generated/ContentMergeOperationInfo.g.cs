using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentMergeOperationInfo(DocuWare.Platform.ServerClient.ContentMergeOperationInfo obj) : IContentMergeOperationInfo
    {
        internal DocuWare.Platform.ServerClient.ContentMergeOperationInfo Obj { get; } = obj;

        public List<int> Documents
        {
            get => Obj.Documents;
            set => Obj.Documents = value;
        }

        public DocuWare.Platform.ServerClient.ContentMergeOperation Operation
        {
            get => Obj.Operation;
            set => Obj.Operation = value;
        }

        public bool Force
        {
            get => Obj.Force;
            set => Obj.Force = value;
        }
    }
}
