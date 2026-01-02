using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUpdateIndexFieldsInfo
    {
		string DialogId { get; set; }
		bool NormalizeCoordinates { get; set; }
		bool ForceUpdate { get; set; }
		List<IDocumentIndexField> Field { get; set; }
    }
}
