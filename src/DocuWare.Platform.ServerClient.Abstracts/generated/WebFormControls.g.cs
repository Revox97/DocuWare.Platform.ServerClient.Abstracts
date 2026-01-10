using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormControls(DocuWare.Platform.ServerClient.WebFormControls obj) : IWebFormControls
    {
        internal DocuWare.Platform.ServerClient.WebFormControls Obj { get; } = obj;

        public List<IWebFormControl> WebFormControl
        {
            get => throw new NotSupportedException("This property is not supported in the Abstracts library at the moment. Use SDK library for this functionality.");
            set => throw new NotSupportedException("This property is not supported in the Abstracts library at the moment. Use SDK library for this functionality.");
        }
    }
}
