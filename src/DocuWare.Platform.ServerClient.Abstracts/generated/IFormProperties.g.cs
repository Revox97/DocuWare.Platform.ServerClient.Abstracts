using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFormProperties
    {
		int FormWidth { get; set; }
		AlignmentType FormAlignment { get; set; }
		string WebPageBackgroundColor { get; set; }
    }
}
