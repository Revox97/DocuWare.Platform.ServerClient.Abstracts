using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntellixFieldMapping(SDK.IntellixFieldMapping obj) : IIntellixFieldMapping
    {
        internal SDK.IntellixFieldMapping Obj { get; } = obj;

        public string FieldDBName
        {
            get => Obj.FieldDBName;
            set => Obj.FieldDBName = value;
        }

        public string IntellixFieldName
        {
            get => Obj.IntellixFieldName;
            set => Obj.IntellixFieldName = value;
        }
    }
}
