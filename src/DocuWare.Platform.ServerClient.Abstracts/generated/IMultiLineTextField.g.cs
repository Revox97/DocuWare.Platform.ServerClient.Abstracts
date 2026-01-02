using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiLineTextField
    {
		int? MinLength { get; set; }
		int? MaxLength { get; set; }
    }
}
