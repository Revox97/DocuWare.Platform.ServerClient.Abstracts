using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormOptionsRows(SDK.WebFormOptionsRows obj) : IWebFormOptionsRows
    {
        internal SDK.WebFormOptionsRows Obj { get; } = obj;

        public List<List<IWebFormOption>> WebFormOptions
        {
            get => Obj.WebFormOptions;
            set => Obj.WebFormOptions = value;
        }
    }
}
