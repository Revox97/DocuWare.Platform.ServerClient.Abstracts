using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormProperties(DocuWare.Platform.ServerClient.FormProperties obj) : IFormProperties
    {
        internal DocuWare.Platform.ServerClient.FormProperties Obj { get; } = obj;

        public int FormWidth
        {
            get => Obj.FormWidth;
            set => Obj.FormWidth = value;
        }

        public AlignmentType FormAlignment
        {
            get => (AlignmentType)Obj.FormAlignment;
            set => Obj.FormAlignment = (DocuWare.Platform.ServerClient.AlignmentType)value;
        }

        public string WebPageBackgroundColor
        {
            get => Obj.WebPageBackgroundColor;
            set => Obj.WebPageBackgroundColor = value;
        }
    }
}
