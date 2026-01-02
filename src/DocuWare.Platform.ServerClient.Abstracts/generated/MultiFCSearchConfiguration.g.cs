using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiFCSearchConfiguration(DocuWare.Platform.ServerClient.WebClient.MultiFCSearchConfiguration obj) : IMultiFCSearchConfiguration
    {
        internal DocuWare.Platform.ServerClient.WebClient.MultiFCSearchConfiguration Obj { get; } = obj;

        public List<string> FcIds
        {
            get => Obj.FcIds;
            set => Obj.FcIds = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string SearchDialogID
        {
            get => Obj.SearchDialogID;
            set => Obj.SearchDialogID = value;
        }

        public string SearchDialogFCID
        {
            get => Obj.SearchDialogFCID;
            set => Obj.SearchDialogFCID = value;
        }

        public Guid Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
