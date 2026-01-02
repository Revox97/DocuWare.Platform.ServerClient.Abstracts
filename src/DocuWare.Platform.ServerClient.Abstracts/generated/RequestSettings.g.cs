using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestSettings(DocuWare.Platform.ServerClient.RequestSettings obj) : IRequestSettings
    {
        internal DocuWare.Platform.ServerClient.RequestSettings Obj { get; } = obj;

        public List<IRequestDecisionSettings> Decisions
        {
            get => Obj.Decisions.Select(x => new RequestDecisionSettings(x) as IRequestDecisionSettings).ToList();
            set => Obj.Decisions = value.Select(x => ((RequestDecisionSettings)x).Obj).ToList();
        }

        public List<IAssignedItem> AssignedItem
        {
            get => Obj.AssignedItem.Select(x => new AssignedItem(x) as IAssignedItem).ToList();
            set => Obj.AssignedItem = value.Select(x => ((AssignedItem)x).Obj).ToList();
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string Description
        {
            get => Obj.Description;
            set => Obj.Description = value;
        }

        public bool IsSequence
        {
            get => Obj.IsSequence;
            set => Obj.IsSequence = value;
        }

        public bool IsAny
        {
            get => Obj.IsAny;
            set => Obj.IsAny = value;
        }

        public int DocId
        {
            get => Obj.DocId;
            set => Obj.DocId = value;
        }

        public string FcGuid
        {
            get => Obj.FcGuid;
            set => Obj.FcGuid = value;
        }

        public string DocumentName
        {
            get => Obj.DocumentName;
            set => Obj.DocumentName = value;
        }

        public bool StampDocument
        {
            get => Obj.StampDocument;
            set => Obj.StampDocument = value;
        }

        public bool SkipEmailSending
        {
            get => Obj.SkipEmailSending;
            set => Obj.SkipEmailSending = value;
        }
    }
}
