using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IColumnValues
    {
		List<IColumnValue> ColumnValue { get; set; }
    }
}
