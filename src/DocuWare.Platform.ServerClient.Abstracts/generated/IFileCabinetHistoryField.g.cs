using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetHistoryField
    {
		string FileCabinetName { get; set; }
		string DocId { get; set; }
		IWFFormFieldValue Value { get; set; }
		IHistoryFieldOptions Options { get; set; }
		AssignmentType AssignmentType { get; set; }
		string Label { get; set; }
		HistoryFormTypeEnum Type { get; set; }
    }
}
