using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TableColumnOptions(SDK.TableColumnOptions obj) : ITableColumnOptions
    {
        internal SDK.TableColumnOptions Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}
