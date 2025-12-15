using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWord
    {
		bool bold { get; set; }
		bool boldSpecified { get; set; }
		int fontSize { get; set; }
		bool fontSizeSpecified { get; set; }
		int L { get; set; }
		int T { get; set; }
		int W { get; set; }
		int H { get; set; }
		string Value { get; set; }
    }
}
