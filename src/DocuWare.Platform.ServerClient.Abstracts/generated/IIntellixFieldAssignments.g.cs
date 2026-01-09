using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IIntellixFieldAssignments{3}
    {
		List<IIntellixFieldMapping> Items { get; set; }
		List<IIntellixTableFieldMapping> IntellixTableFieldItems { get; set; }
		string IntellixLanguage { get; set; }
    }
}
