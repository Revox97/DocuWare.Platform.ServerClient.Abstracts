using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentDivideOperationInfo(DocuWare.Platform.ServerClient.ContentDivideOperationInfo obj) : IContentDivideOperationInfo
    {
        internal DocuWare.Platform.ServerClient.ContentDivideOperationInfo Obj { get; } = obj;

        public List<int> Pages
        {
            get => Obj.Pages;
            set => Obj.Pages = value;
        }

        public List<string> ResultNames
        {
            get => Obj.ResultNames;
            set => Obj.ResultNames = value;
        }

        public ContentDivideOperation Operation
        {
            get => (ContentDivideOperation)Obj.Operation;
            set => Obj.Operation = (DocuWare.Platform.ServerClient.ContentDivideOperation)value;
        }

        public bool Force
        {
            get => Obj.Force;
            set => Obj.Force = value;
        }
    }
}
