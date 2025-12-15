using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISortedField
    {
		string Field { get; set; }
		DocuWare.Platform.ServerClient.SortDirection Direction { get; set; }
    }
}
