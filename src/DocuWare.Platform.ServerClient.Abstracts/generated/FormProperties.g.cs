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

        public DocuWare.Platform.ServerClient.AlignmentType FormAlignment
        {
            get => Obj.FormAlignment;
            set => Obj.FormAlignment = value;
        }

        public string WebPageBackgroundColor
        {
            get => Obj.WebPageBackgroundColor;
            set => Obj.WebPageBackgroundColor = value;
        }
    }
}
