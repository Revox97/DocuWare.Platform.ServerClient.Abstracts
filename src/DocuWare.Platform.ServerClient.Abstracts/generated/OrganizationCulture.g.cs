using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class OrganizationCulture(SDK.OrganizationCulture obj) : IOrganizationCulture
    {
        internal SDK.OrganizationCulture Obj { get; } = obj;

		public string Language
		{
			get => Obj.Language;
			set => Obj.Language = value;
		}

		public string DateAndNumberFormatCulture
		{
			get => Obj.DateAndNumberFormatCulture;
			set => Obj.DateAndNumberFormatCulture = value;
		}
    }
}
