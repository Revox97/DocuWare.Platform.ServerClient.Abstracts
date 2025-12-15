using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ApplicationProperties(SDK.ApplicationProperties obj) : IApplicationProperties
    {
        internal SDK.ApplicationProperties Obj { get; } = obj;

		public List<IApplicationProperty> ApplicationProperties1
		{
			get => Obj.ApplicationProperties1.Select(x => new ApplicationProperty(x) as IApplicationProperty).ToList();
			set => Obj.ApplicationProperties1 = value.Select(x => ((ApplicationProperty)x).Obj).ToList();
		}
    }
}
