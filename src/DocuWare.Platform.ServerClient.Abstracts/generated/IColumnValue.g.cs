using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IColumnValue
    {
		ITaskFieldValue Value { get; set; }
		string Id { get; set; }
    }
}
