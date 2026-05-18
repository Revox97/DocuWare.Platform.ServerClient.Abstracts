using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
