using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormControls(DocuWare.Platform.ServerClient.WebFormControls obj) : IWebFormControls
    {
        internal DocuWare.Platform.ServerClient.WebFormControls Obj { get; } = obj;

        public List<IWebFormControl> WebFormControl
        {
            get => throw new NotSupportedException("This feature is currently not available, it will be implemented with a future version");
            set => throw new NotSupportedException("This feature is currently not available, it will be implemented with a future version");
        }
    }
}
