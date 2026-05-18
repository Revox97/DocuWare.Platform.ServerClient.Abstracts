using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldMapping(SDK.FieldMapping obj) : IFieldMapping
    {
        internal SDK.FieldMapping Obj { get; } = obj;

        public List<IFieldMapping> ColumnMappings
        {
            get => Obj.ColumnMappings.Select(x => new FieldMapping(x) as IFieldMapping).ToList();
            set => Obj.ColumnMappings = value.Select(x => ((FieldMapping)x).Obj).ToList();
        }

        public string Source
        {
            get => Obj.Source;
            set => Obj.Source = value;
        }

        public string Destination
        {
            get => Obj.Destination;
            set => Obj.Destination = value;
        }
    }
}
