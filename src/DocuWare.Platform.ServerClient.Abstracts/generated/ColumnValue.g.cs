using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ColumnValue(SDK.ColumnValue obj) : IColumnValue
    {
        internal SDK.ColumnValue Obj { get; } = obj;

        public ITaskFieldValue Value
        {
            get => new TaskFieldValue(Obj.Value);
            set => Obj.Value = ((TaskFieldValue)value).Obj;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
