using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAuditQuery(SDK.DocumentAuditQuery obj) : IDocumentAuditQuery
    {
        internal SDK.DocumentAuditQuery Obj { get; } = obj;

        public int Start
        {
            get => Obj.Start;
            set => Obj.Start = value;
        }

        public int Count
        {
            get => Obj.Count;
            set => Obj.Count = value;
        }

        public DateTime FromDate
        {
            get => Obj.FromDate;
            set => Obj.FromDate = value;
        }

        public DateTime ToDate
        {
            get => Obj.ToDate;
            set => Obj.ToDate = value;
        }
    }
}
