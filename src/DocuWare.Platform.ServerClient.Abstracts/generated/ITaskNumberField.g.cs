using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskNumberField : ICommonFormField
    {
		int Precision { get; set; }
		bool CalculateSum { get; set; }
    }
}
