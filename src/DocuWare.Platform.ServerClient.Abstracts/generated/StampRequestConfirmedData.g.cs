using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampRequestConfirmedData(DocuWare.Platform.ServerClient.StampRequestConfirmedData obj) : IStampRequestConfirmedData
    {
        internal DocuWare.Platform.ServerClient.StampRequestConfirmedData Obj { get; } = obj;

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
