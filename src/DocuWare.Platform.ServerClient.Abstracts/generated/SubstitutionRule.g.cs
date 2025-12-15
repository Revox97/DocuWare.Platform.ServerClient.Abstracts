using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SubstitutionRule(SDK.SubstitutionRule obj) : ISubstitutionRule
    {
        internal SDK.SubstitutionRule Obj { get; } = obj;

		public string Name
		{
			get => Obj.Name;
			set => Obj.Name = value;
		}

		public bool Active
		{
			get => Obj.Active;
			set => Obj.Active = value;
		}

		public string Guid
		{
			get => Obj.Guid;
			set => Obj.Guid = value;
		}
    }
}
