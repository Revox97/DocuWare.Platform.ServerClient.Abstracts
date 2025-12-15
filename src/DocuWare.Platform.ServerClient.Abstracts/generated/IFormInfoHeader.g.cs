using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFormInfoHeader
    {
		string Id { get; set; }
		string Name { get; set; }
		string SanitizedName { get; set; }
		string Description { get; set; }
		bool Usage { get; set; }
		bool Admin { get; set; }
		bool Active { get; set; }
		bool Public { get; set; }
    }
}
