using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CFSStatisticGeneral(DocuWare.Platform.ServerClient.CFSStatisticGeneral obj) : ICFSStatisticGeneral
    {
        internal DocuWare.Platform.ServerClient.CFSStatisticGeneral Obj { get; } = obj;

        public List<ICFSStatisticSpecific> StatisticSpecific
        {
            get => Obj.StatisticSpecific.Select(x => new CFSStatisticSpecific(x) as ICFSStatisticSpecific).ToList();
            set => Obj.StatisticSpecific = value.Select(x => ((CFSStatisticSpecific)x).Obj).ToList();
        }

        public string CustomerID
        {
            get => Obj.CustomerID;
            set => Obj.CustomerID = value;
        }

        public string ModuleName
        {
            get => Obj.ModuleName;
            set => Obj.ModuleName = value;
        }

        public DateTime CreatedAt
        {
            get => Obj.CreatedAt;
            set => Obj.CreatedAt = value;
        }
    }
}
