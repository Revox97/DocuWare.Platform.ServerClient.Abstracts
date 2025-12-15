using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentDivideOperationInfo(SDK.ContentDivideOperationInfo obj) : IContentDivideOperationInfo
    {
        internal SDK.ContentDivideOperationInfo Obj { get; } = obj;

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

        public DocuWare.Platform.ServerClient.ContentDivideOperation Operation
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
