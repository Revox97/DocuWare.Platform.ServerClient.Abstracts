using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class OrganizationCulture(SDK.OrganizationCulture obj) : IOrganizationCulture
    {
        internal SDK.OrganizationCulture Obj { get; } = obj;

        public CalendarType DateAndNumberFormatCalendar
        {
            get => (CalendarType)Obj.DateAndNumberFormatCalendar;
            set => Obj.DateAndNumberFormatCalendar = (DocuWare.Platform.ServerClient.CalendarType)value;
        }

        public string Language
        {
            get => Obj.Language;
            set => Obj.Language = value;
        }

        public string DateAndNumberFormatCulture
        {
            get => Obj.DateAndNumberFormatCulture;
            set => Obj.DateAndNumberFormatCulture = value;
        }
    }
}
