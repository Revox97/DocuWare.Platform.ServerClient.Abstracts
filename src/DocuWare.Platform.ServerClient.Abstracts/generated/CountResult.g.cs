using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CountResult(DocuWare.Platform.ServerClient.CountResult obj) : ICountResult
    {
        internal DocuWare.Platform.ServerClient.CountResult Obj { get; } = obj;

        public List<ICountResultItem> Group
        {
            get => Obj.Group.Select(x => new CountResultItem(x) as ICountResultItem).ToList();
            set => Obj.Group = value.Select(x => ((CountResultItem)x).Obj).ToList();
        }

        public DateTime TimeStamp
        {
            get => Obj.TimeStamp;
            set => Obj.TimeStamp = value;
        }

        public string FileCabinetId
        {
            get => Obj.FileCabinetId;
            set => Obj.FileCabinetId = value;
        }

        public string OrganizationGuid
        {
            get => Obj.OrganizationGuid;
            set => Obj.OrganizationGuid = value;
        }
    }
}
