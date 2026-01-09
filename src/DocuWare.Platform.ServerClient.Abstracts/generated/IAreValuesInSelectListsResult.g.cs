using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAreValuesInSelectListsResult{3}
    {
		bool Result { get; set; }
		List<ISelectListValueToCheck> IncorrectValues { get; set; }
    }
}
