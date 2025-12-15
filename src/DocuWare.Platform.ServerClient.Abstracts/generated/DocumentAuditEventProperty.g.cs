using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentAuditEventProperty(SDK.DocumentAuditEventProperty obj) : IDocumentAuditEventProperty
    {
        internal SDK.DocumentAuditEventProperty Obj { get; } = obj;

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
			get => new WFieldType(Obj.DWFieldType);
			set => Obj.DWFieldType = ((WFieldType)value).Obj;
		}
    }
}
