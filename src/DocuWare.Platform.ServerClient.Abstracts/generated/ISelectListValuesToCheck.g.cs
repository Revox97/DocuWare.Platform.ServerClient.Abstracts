using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISelectListValuesToCheck{3}
    {
		List<ISelectListValueToCheck> Values { get; set; }
		bool ReturnIncorrectValues { get; set; }
    }
}
