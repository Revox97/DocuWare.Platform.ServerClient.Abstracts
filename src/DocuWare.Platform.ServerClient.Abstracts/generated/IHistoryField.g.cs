using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHistoryField
    {
		IWFFormFieldValue Value { get; set; }
		IHistoryFieldOptions Options { get; set; }
		DocuWare.Platform.ServerClient.AssignmentType AssignmentType { get; set; }
		string Label { get; set; }
		DocuWare.Platform.ServerClient.HistoryFormTypeEnum Type { get; set; }
    }
}
