using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IToggleBehaviorAction
    {
		bool Enabled { get; set; }
		string Name { get; set; }
    }
}
