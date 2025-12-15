using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UploadTemplateInput(SDK.UploadTemplateInput obj) : IUploadTemplateInput
    {
        internal SDK.UploadTemplateInput Obj { get; } = obj;

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

		public string FileData
		{
			get => Obj.FileData;
			set => Obj.FileData = value;
		}
    }
}
