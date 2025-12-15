using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILinkRelation
    {
		List<ILinkInvoke> Invoke { get; set; }
		string Name { get; set; }
		string IntroducedIn { get; set; }
    }
}
