using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class GetTemplateImageInput(DocuWare.Platform.ServerClient.GetTemplateImageInput obj) : IGetTemplateImageInput
    {
        internal DocuWare.Platform.ServerClient.GetTemplateImageInput Obj { get; } = obj;

        public string TemplateGUID
        {
            get => Obj.TemplateGUID;
            set => Obj.TemplateGUID = value;
        }

        public string FileName
        {
            get => Obj.FileName;
            set => Obj.FileName = value;
        }

        public int PageNumber
        {
            get => Obj.PageNumber;
            set => Obj.PageNumber = value;
        }
    }
}
