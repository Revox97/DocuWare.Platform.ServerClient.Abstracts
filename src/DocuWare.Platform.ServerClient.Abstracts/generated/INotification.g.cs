using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface INotification{3}
    {
		DateTime? TimeStamp { get; set; }
		bool IsActive { get; set; }
		string Name { get; set; }
    }
}
