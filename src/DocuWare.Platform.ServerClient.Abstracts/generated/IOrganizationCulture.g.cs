using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOrganizationCulture
    {
		CalendarType DateAndNumberFormatCalendar { get; set; }
		string Language { get; set; }
		string DateAndNumberFormatCulture { get; set; }
    }
}
