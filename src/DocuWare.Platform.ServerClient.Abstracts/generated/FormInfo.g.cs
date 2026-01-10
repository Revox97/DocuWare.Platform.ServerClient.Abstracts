using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormInfo(DocuWare.Platform.ServerClient.FormInfo obj) : IFormInfo
    {
        internal DocuWare.Platform.ServerClient.FormInfo Obj { get; } = obj;

        public List<IWebFormControl> Fields
        {
            get => throw new NotSupportedException("This property is not supported in the Abstracts library at the moment. Use SDK library for this functionality.");
            set => throw new NotSupportedException("This property is not supported in the Abstracts library at the moment. Use SDK library for this functionality.");
        }

        public List<IBehavior> Behaviors
        {
            get => Obj.Behaviors.Select(x => new Behavior(x) as IBehavior).ToList();
            set => Obj.Behaviors = value.Select(x => ((Behavior)x).Obj).ToList();
        }

        public List<ICustomFieldValidation> FieldValidations
        {
            get => Obj.FieldValidations.Select(x => new CustomFieldValidation(x) as ICustomFieldValidation).ToList();
            set => Obj.FieldValidations = value.Select(x => ((CustomFieldValidation)x).Obj).ToList();
        }

        public bool Public
        {
            get => Obj.Public;
            set => Obj.Public = value;
        }
    }
}
