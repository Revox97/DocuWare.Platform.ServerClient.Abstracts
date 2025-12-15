using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ILine
    {
		List<Object> Items { get; set; }
		bool bold { get; set; }
		bool boldSpecified { get; set; }
		int fontSize { get; set; }
		bool fontSizeSpecified { get; set; }
		int BaseLine { get; set; }
		bool BaseLineSpecified { get; set; }
		int L { get; set; }
		int T { get; set; }
		int W { get; set; }
		int H { get; set; }
    }
}
