using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TableFieldColumns(DocuWare.Platform.ServerClient.TableFieldColumns obj) : ITableFieldColumns
    {
        internal DocuWare.Platform.ServerClient.TableFieldColumns Obj { get; } = obj;

        public List<IFileCabinetFieldBase> TableFieldColumn
        {
            get => Obj.TableFieldColumn.Select(x => new FileCabinetFieldBase(x) as IFileCabinetFieldBase).ToList();
            set => Obj.TableFieldColumn = value.Select(x => ((FileCabinetFieldBase)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
