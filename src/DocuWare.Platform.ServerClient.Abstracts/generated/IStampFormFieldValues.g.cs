using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IStampFormFieldValues{3}
    {
		List<IFormFieldValue> Field { get; set; }
		string StampId { get; set; }
    }
}
