using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHistoryField
    {
		string Label { get; set; }
		DocuWare.Platform.ServerClient.HistoryFormTypeEnum Type { get; set; }
    }
}
