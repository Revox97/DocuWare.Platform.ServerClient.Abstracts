using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TokenDescription(DocuWare.Platform.ServerClient.TokenDescription obj) : ITokenDescription
    {
        internal DocuWare.Platform.ServerClient.TokenDescription Obj { get; } = obj;

        public List<DocuWare.Platform.ServerClient.DWProductTypes> TargetProducts
        {
            get => Obj.TargetProducts;
            set => Obj.TargetProducts = value;
        }

        public DocuWare.Platform.ServerClient.TokenUsage Usage
        {
            get => Obj.Usage;
            set => Obj.Usage = value;
        }

        public string Lifetime
        {
            get => Obj.Lifetime;
            set => Obj.Lifetime = value;
        }
    }
}
