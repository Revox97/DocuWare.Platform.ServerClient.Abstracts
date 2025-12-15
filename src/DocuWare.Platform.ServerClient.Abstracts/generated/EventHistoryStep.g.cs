using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EventHistoryStep(SDK.EventHistoryStep obj) : IEventHistoryStep
    {
        internal SDK.EventHistoryStep Obj { get; } = obj;

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
