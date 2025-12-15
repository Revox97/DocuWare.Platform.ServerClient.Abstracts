using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOutOfOffice
    {
		bool IsOutOfOffice { get; set; }
		DateTime StartDateTime { get; set; }
		bool StartDateTimeSpecified { get; set; }
		DateTime EndDateTime { get; set; }
		bool EndDateTimeSpecified { get; set; }
    }
}
