using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICFSStatisticGeneral
    {
		List<ICFSStatisticSpecific> StatisticSpecific { get; set; }
		string CustomerID { get; set; }
		string ModuleName { get; set; }
		DateTime CreatedAt { get; set; }
    }
}
