using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISubstitutionRule
    {
		string Name { get; set; }
		bool Active { get; set; }
		string Guid { get; set; }
    }
}
