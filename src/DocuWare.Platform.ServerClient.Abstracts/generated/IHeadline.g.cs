using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IHeadline : IWebFormField
    {
		double FontSize { get; set; }
		AlignmentType Alignment { get; set; }
		string Subtitle { get; set; }
    }
}
