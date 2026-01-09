using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICreatedInfo
    {
		string User { get; set; }
		DateTime Time { get; set; }
    }
}
