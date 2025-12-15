using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class InputSection(SDK.InputSection obj) : IInputSection
    {
        internal SDK.InputSection Obj { get; } = obj;

        public IFileUploadInfo FileUpload => Obj.FileUpload;

        public List<IApplicationProperty> ApplicationProperties
        {
            get => Obj.ApplicationProperties.Select(x => new ApplicationProperty(x) as IApplicationProperty).ToList();
            set => Obj.ApplicationProperties = value.Select(x => ((ApplicationProperty)x).Obj).ToList();
        }
    }
}
