using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogField: IDialogFieldBase
    {
		List<IDialogFieldBase> DialogTableFieldColumns { get; set; }
		bool UsedAsDocumentName { get; set; }
		bool IsHierarchy { get; set; }
		string SampleEditText { get; set; }
		List<IDocumentIndexFieldValue> PrefillValue { get; set; }
		List<DynamicValueType> DynamicPrefillValue { get; set; }
		List<ISelectListInfo> SelectListInfos { get; set; }
		Link[] Links { get; set; }
		string DBFieldName { get; set; }
		string DlgLabel { get; set; }
		DWFieldType DWFieldType { get; set; }
		bool Locked { get; set; }
		bool ReadOnly { get; set; }
		bool NotEmpty { get; set; }
		bool Visible { get; set; }
		int Length { get; set; }
		int Precision { get; set; }
		bool AllowExtendedSearch { get; set; }
		bool AllowFiltering { get; set; }
		bool SelectListOnly { get; set; }
		SelectListType SelectListType { get; set; }
		bool AssignedInternalSelectList { get; set; }
		string SequenceId { get; set; }
		bool SelectListsAssigned { get; set; }
		bool CalculateSum { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
