using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IParameterDescription
    {
		string Name { get; set; }
		string Description { get; set; }
    }
}
