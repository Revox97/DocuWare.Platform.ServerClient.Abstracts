using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TableHistoryFieldOptions(SDK.TableHistoryFieldOptions obj) : ITableHistoryFieldOptions
    {
        internal SDK.TableHistoryFieldOptions Obj { get; } = obj;

        public List<ITableColumnsDefinition> TableColumnsDefinitions
        {
            get => Obj.TableColumnsDefinitions.Select(x => new TableColumnsDefinition(x) as ITableColumnsDefinition).ToList();
            set => Obj.TableColumnsDefinitions = value.Select(x => ((TableColumnsDefinition)x).Obj).ToList();
        }
    }
}
