using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UploadTemplateResult(SDK.UploadTemplateResult obj) : IUploadTemplateResult
    {
        internal SDK.UploadTemplateResult Obj { get; } = obj;

        public string TemplateGUID
        {
            get => Obj.TemplateGUID;
            set => Obj.TemplateGUID = value;
        }

        public int TotalNumberOfPages
        {
            get => Obj.TotalNumberOfPages;
            set => Obj.TotalNumberOfPages = value;
        }
    }
}
