using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Calendar(SDK.Calendar obj) : ICalendar
    {
        internal SDK.Calendar Obj { get; } = obj;

		public string TimeZoneId
		{
			get => Obj.TimeZoneId;
			set => Obj.TimeZoneId = value;
		}
    }
}
