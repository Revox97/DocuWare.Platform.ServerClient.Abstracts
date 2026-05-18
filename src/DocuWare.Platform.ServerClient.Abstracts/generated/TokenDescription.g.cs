using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TokenDescription(SDK.TokenDescription obj) : ITokenDescription
    {
        internal SDK.TokenDescription Obj { get; } = obj;

        public List<DWProductTypes> TargetProducts
        {
            get => Obj.TargetProducts.ConvertAll(o => (DWProductTypes)o);
            set => Obj.TargetProducts = value.ConvertAll(v => (DocuWare.Platform.ServerClient.DWProductTypes)v);
        }

        public TokenUsage Usage
        {
            get => (TokenUsage)Obj.Usage;
            set => Obj.Usage = (DocuWare.Platform.ServerClient.TokenUsage)value;
        }

        public string Lifetime
        {
            get => Obj.Lifetime;
            set => Obj.Lifetime = value;
        }
    }
}
