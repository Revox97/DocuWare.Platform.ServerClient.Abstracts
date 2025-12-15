using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntellixFieldAssignments(SDK.IntellixFieldAssignments obj) : IIntellixFieldAssignments
    {
        internal SDK.IntellixFieldAssignments Obj { get; } = obj;

		public List<IIntellixFieldMapping> Items
		{
			get => Obj.Items.Select(x => new IntellixFieldMapping(x) as IIntellixFieldMapping).ToList();
			set => Obj.Items = value.Select(x => ((IntellixFieldMapping)x).Obj).ToList();
		}

		public List<IIntellixTableFieldMapping> IntellixTableFieldItems
		{
			get => Obj.IntellixTableFieldItems.Select(x => new IntellixTableFieldMapping(x) as IIntellixTableFieldMapping).ToList();
			set => Obj.IntellixTableFieldItems = value.Select(x => ((IntellixTableFieldMapping)x).Obj).ToList();
		}

		public string IntellixLanguage
		{
			get => Obj.IntellixLanguage;
			set => Obj.IntellixLanguage = value;
		}
    }
}
