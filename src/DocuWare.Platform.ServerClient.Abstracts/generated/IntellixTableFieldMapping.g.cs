using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntellixTableFieldMapping(SDK.IntellixTableFieldMapping obj) : IIntellixTableFieldMapping
    {
        internal SDK.IntellixTableFieldMapping Obj { get; } = obj;

		public List<IIntellixTableFieldColumnMapping> TableFieldColumnMapping
		{
			get => Obj.TableFieldColumnMapping.Select(x => new IntellixTableFieldColumnMapping(x) as IIntellixTableFieldColumnMapping).ToList();
			set => Obj.TableFieldColumnMapping = value.Select(x => ((IntellixTableFieldColumnMapping)x).Obj).ToList();
		}

		public string FieldDBName
		{
			get => Obj.FieldDBName;
			set => Obj.FieldDBName = value;
		}
    }
}
