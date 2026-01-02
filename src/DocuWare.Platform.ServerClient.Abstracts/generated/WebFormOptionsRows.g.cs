using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormOptionsRows(DocuWare.Platform.ServerClient.WebFormOptionsRows obj) : IWebFormOptionsRows
    {
        internal DocuWare.Platform.ServerClient.WebFormOptionsRows Obj { get; } = obj;

        public List<List<IWebFormOption>> WebFormOptions
        {
            get => Obj.WebFormOptions;
            set => Obj.WebFormOptions = value;
        }
    }
}
