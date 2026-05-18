using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CountResult(SDK.CountResult obj) : ICountResult
    {
        internal SDK.CountResult Obj { get; } = obj;

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

        public string LastAccessUser
        {
            get => Obj.LastAccessUser;
            set => Obj.LastAccessUser = value;
        }
    }
}
