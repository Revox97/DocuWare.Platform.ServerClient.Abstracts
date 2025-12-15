using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILinkParameter
    {
		string Url { get; set; }
		string Label { get; set; }
    }
}
