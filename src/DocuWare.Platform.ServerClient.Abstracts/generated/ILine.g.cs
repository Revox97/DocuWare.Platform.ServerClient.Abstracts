using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILine: IRectangleBase
    {
		List<object> Items { get; set; }
		bool bold { get; set; }
		int fontSize { get; set; }
		int BaseLine { get; set; }
		int L { get; set; }
		int T { get; set; }
		int W { get; set; }
		int H { get; set; }
    }
}
