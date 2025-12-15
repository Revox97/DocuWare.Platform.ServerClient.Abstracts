using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISortedField
    {
		string Field { get; set; }
		SortDirection Direction { get; set; }
    }
}
