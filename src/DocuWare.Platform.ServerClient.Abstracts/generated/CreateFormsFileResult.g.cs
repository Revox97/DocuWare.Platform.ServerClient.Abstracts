using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CreateFormsFileResult(SDK.CreateFormsFileResult obj) : ICreateFormsFileResult
    {
        internal SDK.CreateFormsFileResult Obj { get; } = obj;

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
