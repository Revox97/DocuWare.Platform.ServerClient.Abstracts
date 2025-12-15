using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWebFormOption
    {
		string Label { get; set; }
		bool Checked { get; set; }
		bool CheckedSpecified { get; set; }
    }
}
