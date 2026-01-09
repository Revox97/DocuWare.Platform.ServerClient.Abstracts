using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskTextField : ICommonFormField
    {
		int Length { get; set; }
    }
}
