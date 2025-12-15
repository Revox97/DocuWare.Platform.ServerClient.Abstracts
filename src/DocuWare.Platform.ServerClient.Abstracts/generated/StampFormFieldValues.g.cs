using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StampFormFieldValues(SDK.StampFormFieldValues obj) : IStampFormFieldValues
    {
        internal SDK.StampFormFieldValues Obj { get; } = obj;

		public List<IFormFieldValue> Field
		{
			get => Obj.Field.Select(x => new FormFieldValue(x) as IFormFieldValue).ToList();
			set => Obj.Field = value.Select(x => ((FormFieldValue)x).Obj).ToList();
		}

		public string StampId
		{
			get => Obj.StampId;
			set => Obj.StampId = value;
		}
    }
}
