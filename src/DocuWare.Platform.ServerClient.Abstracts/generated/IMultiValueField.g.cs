using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiValueField : ICommonFormField
    {
		bool IsMultiselect { get; set; }
    }
}
