using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampPlacement
    {
		IPolyLineEntry Strokes { get; set; }
		IDWPoint Location { get; set; }
		List<IFormFieldValue> Field { get; set; }
		string StampId { get; set; }
		int Rotation { get; set; }
		int Layer { get; set; }
		string Password { get; set; }
    }
}
