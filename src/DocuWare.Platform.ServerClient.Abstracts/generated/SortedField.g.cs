using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SortedField(SDK.SortedField obj) : ISortedField
    {
        internal SDK.SortedField Obj { get; } = obj;

        public string Field
        {
            get => Obj.Field;
            set => Obj.Field = value;
        }

        public SortDirection Direction
        {
            get => (SortDirection)Obj.Direction;
            set => Obj.Direction = (DocuWare.Platform.ServerClient.SortDirection)value;
        }
    }
}
