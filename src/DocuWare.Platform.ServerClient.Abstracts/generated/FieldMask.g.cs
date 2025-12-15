using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldMask(SDK.FieldMask obj) : IFieldMask
    {
        internal SDK.FieldMask Obj { get; } = obj;

		public string ErrorText
		{
			get => Obj.ErrorText;
			set => Obj.ErrorText = value;
		}

		public string RegularExpression
		{
			get => Obj.RegularExpression;
			set => Obj.RegularExpression = value;
		}

		public string SampleEditText
		{
			get => Obj.SampleEditText;
			set => Obj.SampleEditText = value;
		}
    }
}
