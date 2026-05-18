using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntellixTableFieldColumnMapping(SDK.IntellixTableFieldColumnMapping obj) : IIntellixTableFieldColumnMapping
    {
        internal SDK.IntellixTableFieldColumnMapping Obj { get; } = obj;

        public string ColumnDBName
        {
            get => Obj.ColumnDBName;
            set => Obj.ColumnDBName = value;
        }
    }
}
