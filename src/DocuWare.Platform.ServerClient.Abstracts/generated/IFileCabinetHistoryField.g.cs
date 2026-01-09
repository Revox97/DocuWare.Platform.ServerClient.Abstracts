using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetHistoryField: IHistoryField
    {
		string Label { get; set; }
		HistoryFormTypeEnum Type { get; set; }
    }
}
