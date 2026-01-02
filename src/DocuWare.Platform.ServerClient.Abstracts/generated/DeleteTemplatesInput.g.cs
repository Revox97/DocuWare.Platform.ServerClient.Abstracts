using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DeleteTemplatesInput(DocuWare.Platform.ServerClient.DeleteTemplatesInput obj) : IDeleteTemplatesInput
    {
        internal DocuWare.Platform.ServerClient.DeleteTemplatesInput Obj { get; } = obj;

        public List<string> TemplateGUIDS
        {
            get => Obj.TemplateGUIDS;
            set => Obj.TemplateGUIDS = value;
        }
    }
}
