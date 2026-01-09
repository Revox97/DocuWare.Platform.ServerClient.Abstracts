using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFieldValueStatisticsResult
    {
		List<IFieldValueStatistics> Item { get; set; }
    }
}
