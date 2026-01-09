using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILinkRelations{3}
    {
		List<ILinkRelation> Relation { get; set; }
		bool IsComplete { get; set; }
    }
}
