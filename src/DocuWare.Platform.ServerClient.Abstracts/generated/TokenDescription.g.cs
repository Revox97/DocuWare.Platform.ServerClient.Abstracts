using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TokenDescription(SDK.TokenDescription obj) : ITokenDescription
    {
        internal SDK.TokenDescription Obj { get; } = obj;

		public List<DWProductTypes> TargetProducts
		{
			get => Obj.TargetProducts.Select(x => new WProductTypes(x) as DWProductTypes).ToList();
			set => Obj.TargetProducts = value.Select(x => ((WProductTypes)x).Obj).ToList();
		}

		public TokenUsage Usage
		{
			get => new okenUsage(Obj.Usage);
			set => Obj.Usage = ((okenUsage)value).Obj;
		}

		public string Lifetime
		{
			get => Obj.Lifetime;
			set => Obj.Lifetime = value;
		}
    }
}
