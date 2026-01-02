using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampRequestConfirmedData(SDK.StampRequestConfirmedData obj) : IStampRequestConfirmedData
    {
        internal SDK.StampRequestConfirmedData Obj { get; } = obj;

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
