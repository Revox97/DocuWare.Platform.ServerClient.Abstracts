using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TableFieldColumns(SDK.TableFieldColumns obj) : ITableFieldColumns
    {
        internal SDK.TableFieldColumns Obj { get; } = obj;

        public List<IFileCabinetFieldBase> TableFieldColumn
        {
            get => Obj.TableFieldColumn.Select(x => new FileCabinetFieldBase(x) as IFileCabinetFieldBase).ToList();
            set => Obj.TableFieldColumn = value.Select(x => ((FileCabinetFieldBase)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
