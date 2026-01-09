using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISelectListValuesToCheck
    {
		List<ISelectListValueToCheck> Values { get; set; }
		bool ReturnIncorrectValues { get; set; }
    }
}
