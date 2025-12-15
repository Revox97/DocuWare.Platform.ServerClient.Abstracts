using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormProperties(SDK.FormProperties obj) : IFormProperties
    {
        internal SDK.FormProperties Obj { get; } = obj;

		public int FormWidth
		{
			get => Obj.FormWidth;
			set => Obj.FormWidth = value;
		}

		public AlignmentType FormAlignment
		{
			get => new lignmentType(Obj.FormAlignment);
			set => Obj.FormAlignment = ((lignmentType)value).Obj;
		}

		public string WebPageBackgroundColor
		{
			get => Obj.WebPageBackgroundColor;
			set => Obj.WebPageBackgroundColor = value;
		}
    }
}
