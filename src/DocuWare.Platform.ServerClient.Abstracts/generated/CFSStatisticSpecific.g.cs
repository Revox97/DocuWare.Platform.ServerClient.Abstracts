using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CFSStatisticSpecific(DocuWare.Platform.ServerClient.CFSStatisticSpecific obj) : ICFSStatisticSpecific
    {
        internal DocuWare.Platform.ServerClient.CFSStatisticSpecific Obj { get; } = obj;

        public List<ICFSSpecificValue> SpecificValue
        {
            get => Obj.SpecificValue.Select(x => new CFSSpecificValue(x) as ICFSSpecificValue).ToList();
            set => Obj.SpecificValue = value.Select(x => ((CFSSpecificValue)x).Obj).ToList();
        }

        public CFSTableNames Category
        {
            get => (CFSTableNames)Obj.Category;
            set => Obj.Category = (DocuWare.Platform.ServerClient.CFSTableNames)value;
        }

        public string ObjectID
        {
            get => Obj.ObjectID;
            set => Obj.ObjectID = value;
        }
    }
}
