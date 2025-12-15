using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ContentMergeOperationInfo(SDK.ContentMergeOperationInfo obj) : IContentMergeOperationInfo
    {
        internal SDK.ContentMergeOperationInfo Obj { get; } = obj;

		public List<int> Documents
		{
			get => Obj.Documents;
			set => Obj.Documents = value;
		}

		public ContentMergeOperation Operation
		{
			get => new ontentMergeOperation(Obj.Operation);
			set => Obj.Operation = ((ontentMergeOperation)value).Obj;
		}

		public bool Force
		{
			get => Obj.Force;
			set => Obj.Force = value;
		}
    }
}
