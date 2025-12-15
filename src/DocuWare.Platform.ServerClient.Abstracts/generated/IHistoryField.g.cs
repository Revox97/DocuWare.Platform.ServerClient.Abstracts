using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHistoryField
    {
		IWFFormFieldValue Value { get; set; }
		IHistoryFieldOptions Options { get; set; }
		AssignmentType AssignmentType { get; set; }
		string Label { get; set; }
		HistoryFormTypeEnum Type { get; set; }
    }
}
