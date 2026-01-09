using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IUpdateIndexFieldsInfo : IDocumentIndexFields
    {
		string DialogId { get; set; }
		bool NormalizeCoordinates { get; set; }
		bool ForceUpdate { get; set; }
    }
}
