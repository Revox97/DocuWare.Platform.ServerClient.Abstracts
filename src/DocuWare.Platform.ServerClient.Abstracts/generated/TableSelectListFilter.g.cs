using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TableSelectListFilter(DocuWare.Platform.ServerClient.TableSelectListFilter obj) : ITableSelectListFilter
    {
        internal DocuWare.Platform.ServerClient.TableSelectListFilter Obj { get; } = obj;

        public string TableFieldColumnName
        {
            get => Obj.TableFieldColumnName;
            set => Obj.TableFieldColumnName = value;
        }
    }
}
