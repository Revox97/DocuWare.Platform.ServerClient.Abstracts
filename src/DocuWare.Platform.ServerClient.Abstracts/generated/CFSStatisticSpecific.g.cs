using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CFSStatisticSpecific(SDK.CFSStatisticSpecific obj) : ICFSStatisticSpecific
    {
        internal SDK.CFSStatisticSpecific Obj { get; } = obj;

        public List<ICFSSpecificValue> SpecificValue
        {
            get => Obj.SpecificValue.Select(x => new CFSSpecificValue(x) as ICFSSpecificValue).ToList();
            set => Obj.SpecificValue = value.Select(x => ((CFSSpecificValue)x).Obj).ToList();
        }

        public DocuWare.Platform.ServerClient.CFSTableNames Category
        {
            get => Obj.Category;
            set => Obj.Category = value;
        }

        public string ObjectID
        {
            get => Obj.ObjectID;
            set => Obj.ObjectID = value;
        }
    }
}
