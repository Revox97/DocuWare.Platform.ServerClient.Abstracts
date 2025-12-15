using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISimplePageContent
    {
		List<ISimpleWord> W { get; set; }
    }
}
