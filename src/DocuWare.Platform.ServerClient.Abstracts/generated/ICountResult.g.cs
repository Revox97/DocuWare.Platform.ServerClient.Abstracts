using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICountResult
    {
		List<ICountResultItem> Group { get; set; }
		DateTime TimeStamp { get; set; }
		string FileCabinetId { get; set; }
		string OrganizationGuid { get; set; }
    }
}
