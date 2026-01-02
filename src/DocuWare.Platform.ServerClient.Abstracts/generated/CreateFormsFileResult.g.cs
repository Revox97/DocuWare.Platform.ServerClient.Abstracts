using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CreateFormsFileResult(DocuWare.Platform.ServerClient.CreateFormsFileResult obj) : ICreateFormsFileResult
    {
        internal DocuWare.Platform.ServerClient.CreateFormsFileResult Obj { get; } = obj;

        public string FilePath
        {
            get => Obj.FilePath;
            set => Obj.FilePath = value;
        }

        public string ContentType
        {
            get => Obj.ContentType;
            set => Obj.ContentType = value;
        }
    }
}
