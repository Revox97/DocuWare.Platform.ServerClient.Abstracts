using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskTableField
    {
		List<ITaskTableColumn> Columns { get; set; }
		string FieldName { get; set; }
		bool Mandatory { get; set; }
		bool IsReadOnly { get; set; }
		DocuWare.Platform.ServerClient.FormTypeEnum FormFieldType { get; set; }
		string Label { get; set; }
		int Id { get; set; }
    }
}
