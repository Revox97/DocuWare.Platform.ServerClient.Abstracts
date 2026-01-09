using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFieldMask
    {
		string ErrorText { get; set; }
		string RegularExpression { get; set; }
		string SampleEditText { get; set; }
    }
}
