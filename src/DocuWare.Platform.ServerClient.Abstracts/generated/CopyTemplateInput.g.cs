using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CopyTemplateInput(SDK.CopyTemplateInput obj) : ICopyTemplateInput
    {
        internal SDK.CopyTemplateInput Obj { get; } = obj;

		public string TemplateGUID
		{
			get => Obj.TemplateGUID;
			set => Obj.TemplateGUID = value;
		}
    }
}
