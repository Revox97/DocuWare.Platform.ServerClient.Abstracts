using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BaseForm(SDK.BaseForm obj) : IBaseForm
    {
        internal SDK.BaseForm Obj { get; } = obj;

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
