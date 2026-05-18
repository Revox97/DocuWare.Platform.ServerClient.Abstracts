using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICommonFormField : IBaseForm
    {
		IWFFormFieldValue PrefillValue { get; set; }
		List<ISelectListFilter> SelectListFilters { get; set; }
		bool Mandatory { get; set; }
		string Description { get; set; }
		bool HasSelectList { get; set; }
		bool IsReadOnly { get; set; }
		bool IsSelectListOnly { get; set; }
		string SelectListGuid { get; set; }
		string SelectListColumn { get; set; }
		bool IsHiddenInStamp { get; set; }
    }
}
