using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TokenDescription(DocuWare.Platform.ServerClient.TokenDescription obj) : ITokenDescription
    {
        internal DocuWare.Platform.ServerClient.TokenDescription Obj { get; } = obj;

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
