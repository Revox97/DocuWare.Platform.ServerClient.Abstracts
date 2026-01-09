using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskTableNumberField: ITaskNumberField
    {
		bool PrefillWithBalance { get; set; }
		string BalanceField { get; set; }
		int Precision { get; set; }
		bool CalculateSum { get; set; }
		List<ISelectListFilter> SelectListFilters { get; set; }
		bool Mandatory { get; set; }
		string Description { get; set; }
		bool HasSelectList { get; set; }
		bool IsReadOnly { get; set; }
		bool IsSelectListOnly { get; set; }
		string SelectListGuid { get; set; }
		string SelectListColumn { get; set; }
		bool IsHiddenInStamp { get; set; }
		FormTypeEnum FormFieldType { get; set; }
		string Label { get; set; }
		int Id { get; set; }
    }
}
