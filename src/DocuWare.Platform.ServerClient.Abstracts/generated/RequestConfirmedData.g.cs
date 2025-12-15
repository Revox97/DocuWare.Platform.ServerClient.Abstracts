using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestConfirmedData(SDK.RequestConfirmedData obj) : IRequestConfirmedData
    {
        internal SDK.RequestConfirmedData Obj { get; } = obj;

		public int DecisionId
		{
			get => Obj.DecisionId;
			set => Obj.DecisionId = value;
		}

		public string Comment
		{
			get => Obj.Comment;
			set => Obj.Comment = value;
		}
    }
}
