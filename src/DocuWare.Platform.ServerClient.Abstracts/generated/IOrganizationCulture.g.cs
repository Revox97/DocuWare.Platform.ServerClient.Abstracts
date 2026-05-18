using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOrganizationCulture
    {
		CalendarType DateAndNumberFormatCalendar { get; set; }
		string Language { get; set; }
		string DateAndNumberFormatCulture { get; set; }
    }
}
