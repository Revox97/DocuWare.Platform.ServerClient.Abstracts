using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAuditEventProperty(DocuWare.Platform.ServerClient.DocumentAuditEventProperty obj) : IDocumentAuditEventProperty
    {
        internal DocuWare.Platform.ServerClient.DocumentAuditEventProperty Obj { get; } = obj;

        public string PropertyName
        {
            get => Obj.PropertyName;
            set => Obj.PropertyName = value;
        }

        public string OldValue
        {
            get => Obj.OldValue;
            set => Obj.OldValue = value;
        }

        public string NewValue
        {
            get => Obj.NewValue;
            set => Obj.NewValue = value;
        }

        public DWFieldType DWFieldType
        {
            get => (DWFieldType)Obj.DWFieldType;
            set => Obj.DWFieldType = (DocuWare.Platform.ServerClient.DWFieldType)value;
        }
    }
}
