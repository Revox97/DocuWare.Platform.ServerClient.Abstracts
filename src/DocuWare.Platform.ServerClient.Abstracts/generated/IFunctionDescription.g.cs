using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFunctionDescription
    {
		List<IParameterDescription> Parameter { get; set; }
		string Name { get; set; }
		int MinParameters { get; set; }
		string MaxParameters { get; set; }
    }
}
