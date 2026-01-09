using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskTableField : IBaseForm
    {
		List<ITaskTableColumn> Columns { get; set; }
		string FieldName { get; set; }
		bool Mandatory { get; set; }
		bool IsReadOnly { get; set; }
    }
}
