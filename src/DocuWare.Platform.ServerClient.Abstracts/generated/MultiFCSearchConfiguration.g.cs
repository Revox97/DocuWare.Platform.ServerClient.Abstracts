using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MultiFCSearchConfiguration(SDK.MultiFCSearchConfiguration obj) : IMultiFCSearchConfiguration
    {
        internal SDK.MultiFCSearchConfiguration Obj { get; } = obj;

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
