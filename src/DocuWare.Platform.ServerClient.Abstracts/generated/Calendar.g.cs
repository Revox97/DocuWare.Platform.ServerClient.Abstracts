using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Calendar(DocuWare.Platform.ServerClient.Calendar obj) : ICalendar
    {
        internal DocuWare.Platform.ServerClient.Calendar Obj { get; } = obj;

        public string TimeZoneId
        {
            get => Obj.TimeZoneId;
            set => Obj.TimeZoneId = value;
        }
    }
}
