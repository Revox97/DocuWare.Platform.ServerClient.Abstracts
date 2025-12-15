using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DeleteTemplatesInput(SDK.DeleteTemplatesInput obj) : IDeleteTemplatesInput
    {
        internal SDK.DeleteTemplatesInput Obj { get; } = obj;

        public List<string> TemplateGUIDS
        {
            get => Obj.TemplateGUIDS;
            set => Obj.TemplateGUIDS = value;
        }
    }
}
