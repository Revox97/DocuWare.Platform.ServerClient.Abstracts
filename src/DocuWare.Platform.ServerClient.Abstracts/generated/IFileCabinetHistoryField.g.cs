using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetHistoryField
    {
		string Label { get; set; }
		DocuWare.Platform.ServerClient.HistoryFormTypeEnum Type { get; set; }
    }
}
