using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAreValuesInSelectListsQuery{3}
    {
		List<ISelectListValueToCheck> Values { get; set; }
		List<string> SelectListIds { get; set; }
		bool ReturnIncorrectValues { get; set; }
    }
}
