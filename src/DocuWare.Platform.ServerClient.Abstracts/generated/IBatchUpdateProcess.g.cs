using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchUpdateProcess
    {
		IBatchUpdateSource Source { get; set; }
		IBatchUpdateProcessData Data { get; set; }
    }
}
