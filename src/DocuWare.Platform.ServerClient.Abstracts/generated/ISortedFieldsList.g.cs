using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISortedFieldsList
    {
		List<ISortedField> OrderBy { get; set; }
    }
}
