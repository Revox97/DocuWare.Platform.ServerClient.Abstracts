using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWord: ISimpleWord
    {
		bool bold { get; set; }
		int fontSize { get; set; }
		int L { get; set; }
		int T { get; set; }
		int W { get; set; }
		int H { get; set; }
		string Value { get; set; }
    }
}
