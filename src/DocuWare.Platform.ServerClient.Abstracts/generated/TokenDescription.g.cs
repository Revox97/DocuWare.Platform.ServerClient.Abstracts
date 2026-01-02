using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TokenDescription(DocuWare.Platform.ServerClient.TokenDescription obj) : ITokenDescription
    {
        internal DocuWare.Platform.ServerClient.TokenDescription Obj { get; } = obj;

        public List<DWProductTypes> TargetProducts
        {
            get => Obj.TargetProducts;
            set => Obj.TargetProducts = value;
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
