using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchUpdateProcessData
    {
		List<IDocumentIndexField> Field { get; set; }
		int? BatchSize { get; set; }
		bool ForceUpdate { get; set; }
    }
}
