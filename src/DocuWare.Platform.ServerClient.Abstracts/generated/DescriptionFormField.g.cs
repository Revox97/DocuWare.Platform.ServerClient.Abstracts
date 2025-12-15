using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DescriptionFormField(SDK.DescriptionFormField obj) : IDescriptionFormField
    {
        internal SDK.DescriptionFormField Obj { get; } = obj;

		public List<ILinkParameter> LinkParameters
		{
			get => Obj.LinkParameters.Select(x => new LinkParameter(x) as ILinkParameter).ToList();
			set => Obj.LinkParameters = value.Select(x => ((LinkParameter)x).Obj).ToList();
		}

		public string DescriptionText
		{
			get => Obj.DescriptionText;
			set => Obj.DescriptionText = value;
		}

		public FormTypeEnum FormFieldType
		{
			get => new ormTypeEnum(Obj.FormFieldType);
			set => Obj.FormFieldType = ((ormTypeEnum)value).Obj;
		}

		public string Label
		{
			get => Obj.Label;
			set => Obj.Label = value;
		}

		public int Id
		{
			get => Obj.Id;
			set => Obj.Id = value;
		}
    }
}
