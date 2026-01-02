using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class InputSection(DocuWare.Platform.ServerClient.InputSection obj) : IInputSection
    {
        internal DocuWare.Platform.ServerClient.InputSection Obj { get; } = obj;

        public List<IApplicationProperty> ApplicationProperties
        {
            get => Obj.ApplicationProperties.Select(x => new ApplicationProperty(x) as IApplicationProperty).ToList();
            set => Obj.ApplicationProperties = value.Select(x => ((ApplicationProperty)x).Obj).ToList();
        }
    }
}
