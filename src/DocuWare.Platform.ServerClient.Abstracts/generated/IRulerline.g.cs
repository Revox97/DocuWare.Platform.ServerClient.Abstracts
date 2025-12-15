using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRulerline
    {
		int lineWidth { get; set; }
		LineStyle style { get; set; }
		int L { get; set; }
		int T { get; set; }
		int W { get; set; }
		int H { get; set; }
    }
}
