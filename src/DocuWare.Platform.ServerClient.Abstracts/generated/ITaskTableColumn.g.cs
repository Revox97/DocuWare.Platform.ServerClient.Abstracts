using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskTableColumn
    {
		ITaskTableColumnBase BaseData { get; set; }
		string FieldName { get; set; }
		bool IsHidden { get; set; }
    }
}
