using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampPlacement{3}
    {
		List<IFormFieldValue> Field { get; set; }
		string StampId { get; set; }
		int Rotation { get; set; }
		int Layer { get; set; }
		string Password { get; set; }
    }
}
