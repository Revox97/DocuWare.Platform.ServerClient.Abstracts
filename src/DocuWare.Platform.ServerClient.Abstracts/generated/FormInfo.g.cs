using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormInfo(SDK.FormInfo obj) : IFormInfo
    {
        internal SDK.FormInfo Obj { get; } = obj;

        public List<IWebFormControl> Fields
        {
            get => Obj.Fields.Select(x => new WebFormControl(x) as IWebFormControl).ToList();
            set => Obj.Fields = value.Select(x => ((WebFormControl)x).Obj).ToList();
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
