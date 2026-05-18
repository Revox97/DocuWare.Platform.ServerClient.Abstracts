using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormInfo(DocuWare.Platform.ServerClient.FormInfo obj) : IFormInfo
    {
        internal DocuWare.Platform.ServerClient.FormInfo Obj { get; } = obj;

        public string ConfigId
        {
            get => Obj.ConfigId;
            set => Obj.ConfigId = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public List<IWebFormControl> Fields
        {
            get
            {
                List<IWebFormControl> fields = [];

                foreach(SDK.WebFormControl formField in Obj.Fields)
                {
                    Type type = formField.GetType();
                    fields.Add(type.GetConstructor(BindingFlags.Public, [typeof(SDK.WebFormControl)]).Invoke([formField]) as IWebFormControl);
                }

                return fields;
            }
            set
            {
                List<SDK.WebFormControl> fields = [];

                foreach(WebFormControl formField in value)
                {
                    Type type = formField.GetType();

                    PropertyInfo objPropertyInfo = type.GetProperty("Obj");
                    SDK.WebFormControl obj = objPropertyInfo.GetValue(formField) as SDK.WebFormControl;

                    fields.Add(obj);
                }

                Obj.Fields = fields;
            }
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

        public IFormProperties FormProperties
        {
            get => new FormProperties(Obj.FormProperties);
            set => Obj.FormProperties = ((FormProperties)value).Obj;
        }

        public ISubmissionOptions SubmissionOptions
        {
            get => new SubmissionOptions(Obj.SubmissionOptions);
            set => Obj.SubmissionOptions = ((SubmissionOptions)value).Obj;
        }

        public bool Public
        {
            get => Obj.Public;
            set => Obj.Public = value;
        }
    }
}
