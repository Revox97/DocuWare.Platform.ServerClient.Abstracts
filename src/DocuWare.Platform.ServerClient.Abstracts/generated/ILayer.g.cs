using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILayer
    {
		List<IEntryBase> Items { get; set; }
		int Id { get; set; }
    }
}
