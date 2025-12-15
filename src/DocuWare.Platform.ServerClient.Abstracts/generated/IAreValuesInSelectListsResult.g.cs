using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAreValuesInSelectListsResult
    {
		bool Result { get; set; }
		List<ISelectListValueToCheck> IncorrectValues { get; set; }
    }
}
