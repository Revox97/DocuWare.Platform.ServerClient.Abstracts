using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IOutOfOffice{3}
    {
		bool IsOutOfOffice { get; set; }
		DateTime StartDateTime { get; set; }
		DateTime EndDateTime { get; set; }
    }
}
