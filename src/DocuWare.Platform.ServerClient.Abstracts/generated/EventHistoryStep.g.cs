using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EventHistoryStep(DocuWare.Platform.ServerClient.EventHistoryStep obj) : IEventHistoryStep
    {
        internal DocuWare.Platform.ServerClient.EventHistoryStep Obj { get; } = obj;

        public string FCName
        {
            get => Obj.FCName;
            set => Obj.FCName = value;
        }

        public string DocId
        {
            get => Obj.DocId;
            set => Obj.DocId = value;
        }

        public string Status
        {
            get => Obj.Status;
            set => Obj.Status = value;
        }
    }
}
