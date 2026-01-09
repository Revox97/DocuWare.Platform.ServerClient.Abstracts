using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestDecisionSettings{3}
    {
		int Id { get; set; }
		string Label { get; set; }
		bool IsActive { get; set; }
		string Color { get; set; }
    }
}
