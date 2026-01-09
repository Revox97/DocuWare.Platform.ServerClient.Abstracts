using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFieldMask{3}
    {
		string ErrorText { get; set; }
		string RegularExpression { get; set; }
		string SampleEditText { get; set; }
    }
}
