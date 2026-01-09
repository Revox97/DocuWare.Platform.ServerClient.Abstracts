using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableSelectListFilter : ISelectListFilter
    {
		string TableFieldColumnName { get; set; }
    }
}
