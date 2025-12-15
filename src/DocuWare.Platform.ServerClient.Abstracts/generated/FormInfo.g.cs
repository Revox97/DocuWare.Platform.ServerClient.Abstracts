using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormInfo(SDK.FormInfo obj) : IFormInfo
    {
        internal SDK.FormInfo Obj { get; } = obj;

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

		public bool PublicSpecified
		{
			get => Obj.PublicSpecified;
			set => Obj.PublicSpecified = value;
		}
    }
}
