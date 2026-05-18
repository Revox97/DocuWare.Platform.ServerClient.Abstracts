using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentlessTriggerData(SDK.DocumentlessTriggerData obj) : IDocumentlessTriggerData
    {
        internal SDK.DocumentlessTriggerData Obj { get; } = obj;

        public List<ITriggerVariable> TextVariables
        {
            get => Obj.TextVariables.Select(x => new TriggerVariable(x) as ITriggerVariable).ToList();
            set => Obj.TextVariables = value.Select(x => ((TriggerVariable)x).Obj).ToList();
        }

        public List<ITriggerVariable> DecimalVariables
        {
            get => Obj.DecimalVariables.Select(x => new TriggerVariable(x) as ITriggerVariable).ToList();
            set => Obj.DecimalVariables = value.Select(x => ((TriggerVariable)x).Obj).ToList();
        }

        public List<ITriggerVariable> DateTimeVariables
        {
            get => Obj.DateTimeVariables.Select(x => new TriggerVariable(x) as ITriggerVariable).ToList();
            set => Obj.DateTimeVariables = value.Select(x => ((TriggerVariable)x).Obj).ToList();
        }

        public List<ITriggerVariable> DateVariables
        {
            get => Obj.DateVariables.Select(x => new TriggerVariable(x) as ITriggerVariable).ToList();
            set => Obj.DateVariables = value.Select(x => ((TriggerVariable)x).Obj).ToList();
        }

        public List<ITriggerVariable> UserVariables
        {
            get => Obj.UserVariables.Select(x => new TriggerVariable(x) as ITriggerVariable).ToList();
            set => Obj.UserVariables = value.Select(x => ((TriggerVariable)x).Obj).ToList();
        }

        public List<ITriggerVariable> MultiUserVariables
        {
            get => Obj.MultiUserVariables.Select(x => new TriggerVariable(x) as ITriggerVariable).ToList();
            set => Obj.MultiUserVariables = value.Select(x => ((TriggerVariable)x).Obj).ToList();
        }

        public List<ITriggerVariable> RoleVariables
        {
            get => Obj.RoleVariables.Select(x => new TriggerVariable(x) as ITriggerVariable).ToList();
            set => Obj.RoleVariables = value.Select(x => ((TriggerVariable)x).Obj).ToList();
        }

        public List<ITriggerVariable> MultiRoleVariables
        {
            get => Obj.MultiRoleVariables.Select(x => new TriggerVariable(x) as ITriggerVariable).ToList();
            set => Obj.MultiRoleVariables = value.Select(x => ((TriggerVariable)x).Obj).ToList();
        }

        public List<ITriggerVariable> SubstitutionRuleVariables
        {
            get => Obj.SubstitutionRuleVariables.Select(x => new TriggerVariable(x) as ITriggerVariable).ToList();
            set => Obj.SubstitutionRuleVariables = value.Select(x => ((TriggerVariable)x).Obj).ToList();
        }

        public List<ITriggerVariable> MultiSubstitutionRuleVariables
        {
            get => Obj.MultiSubstitutionRuleVariables.Select(x => new TriggerVariable(x) as ITriggerVariable).ToList();
            set => Obj.MultiSubstitutionRuleVariables = value.Select(x => ((TriggerVariable)x).Obj).ToList();
        }

        public List<ITriggerVariable> KeywordVariables
        {
            get => Obj.KeywordVariables.Select(x => new TriggerVariable(x) as ITriggerVariable).ToList();
            set => Obj.KeywordVariables = value.Select(x => ((TriggerVariable)x).Obj).ToList();
        }

        public string ExpectedDefinitionId
        {
            get => Obj.ExpectedDefinitionId;
            set => Obj.ExpectedDefinitionId = value;
        }
    }
}
