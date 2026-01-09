using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWord : ISimpleWord
    {
		bool bold { get; set; }
		int fontSize { get; set; }
    }
}
