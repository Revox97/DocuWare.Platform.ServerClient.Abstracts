using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SubstitutionRules(SDK.SubstitutionRules obj) : ISubstitutionRules
    {
        internal SDK.SubstitutionRules Obj { get; } = obj;

        public List<ISubstitutionRule> Item
        {
            get => Obj.Item.Select(x => new SubstitutionRule(x) as ISubstitutionRule).ToList();
            set => Obj.Item = value.Select(x => ((SubstitutionRule)x).Obj).ToList();
        }
    }
}
