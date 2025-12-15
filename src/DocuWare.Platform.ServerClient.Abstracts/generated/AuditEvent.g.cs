using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AuditEvent(SDK.AuditEvent obj) : IAuditEvent
    {
        internal SDK.AuditEvent Obj { get; } = obj;

		public string Id
		{
			get => Obj.Id;
			set => Obj.Id = value;
		}

		public string Event
		{
			get => Obj.Event;
			set => Obj.Event = value;
		}

		public string Type
		{
			get => Obj.Type;
			set => Obj.Type = value;
		}

		public string Name
		{
			get => Obj.Name;
			set => Obj.Name = value;
		}

		public string User
		{
			get => Obj.User;
			set => Obj.User = value;
		}

		public DateTime Date
		{
			get => Obj.Date;
			set => Obj.Date = value;
		}

		public bool DateSpecified
		{
			get => Obj.DateSpecified;
			set => Obj.DateSpecified = value;
		}
    }
}
