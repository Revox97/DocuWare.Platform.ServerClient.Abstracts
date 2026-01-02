using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Dialog(DocuWare.Platform.ServerClient.Dialog obj) : IDialog
    {
        internal DocuWare.Platform.ServerClient.Dialog Obj { get; } = obj;

        public List<IDialogField> Fields
        {
            get => Obj.Fields.Select(x => new DialogField(x) as IDialogField).ToList();
            set => Obj.Fields = value.Select(x => ((DialogField)x).Obj).ToList();
        }

        public bool HasValidation
        {
            get => Obj.HasValidation;
            set => Obj.HasValidation = value;
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string FileCabinetId
        {
            get => Obj.FileCabinetId;
            set => Obj.FileCabinetId = value;
        }

        public string FileCabinetName
        {
            get => Obj.FileCabinetName;
            set => Obj.FileCabinetName = value;
        }

        public string DisplayName
        {
            get => Obj.DisplayName;
            set => Obj.DisplayName = value;
        }

        public bool IsForMobile
        {
            get => Obj.IsForMobile;
            set => Obj.IsForMobile = value;
        }

        public string AssignedDialogId
        {
            get => Obj.AssignedDialogId;
            set => Obj.AssignedDialogId = value;
        }

        public string Color
        {
            get => Obj.Color;
            set => Obj.Color = value;
        }

        public bool IsDefault
        {
            get => Obj.IsDefault;
            set => Obj.IsDefault = value;
        }

        public DialogTypes Type
        {
            get => (DialogTypes)Obj.Type;
            set => Obj.Type = (DocuWare.Platform.ServerClient.DialogTypes)value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
