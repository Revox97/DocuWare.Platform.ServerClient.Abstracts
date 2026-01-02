using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class GetTemplateImageResult(DocuWare.Platform.ServerClient.GetTemplateImageResult obj) : IGetTemplateImageResult
    {
        internal DocuWare.Platform.ServerClient.GetTemplateImageResult Obj { get; } = obj;

        public string FileName
        {
            get => Obj.FileName;
            set => Obj.FileName = value;
        }

        public string FileData
        {
            get => Obj.FileData;
            set => Obj.FileData = value;
        }

        public int ImageDPI
        {
            get => Obj.ImageDPI;
            set => Obj.ImageDPI = value;
        }
    }
}
