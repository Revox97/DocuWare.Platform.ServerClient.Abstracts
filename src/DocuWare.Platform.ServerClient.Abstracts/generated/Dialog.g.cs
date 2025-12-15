using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Dialog(SDK.Dialog obj) : IDialog
    {
        internal SDK.Dialog Obj { get; } = obj;

		public List<IDialogField> Fields
		{
			get => Obj.Fields.Select(x => new DialogField(x) as IDialogField).ToList();
			set => Obj.Fields = value.Select(x => ((DialogField)x).Obj).ToList();
		}

		public IDocumentsQuery Query
		{
			get => new DocumentsQuery(Obj.Query);
			set => Obj.Query = ((DocumentsQuery)value).Obj;
		}

		public IDialogProperties Properties
		{
			get => new DialogProperties(Obj.Properties);
			set => Obj.Properties = ((DialogProperties)value).Obj;
		}

		public IIntellixFieldAssignments IntellixFieldAssignments
		{
			get => new IntellixFieldAssignments(Obj.IntellixFieldAssignments);
			set => Obj.IntellixFieldAssignments = ((IntellixFieldAssignments)value).Obj;
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
			get => new ialogTypes(Obj.Type);
			set => Obj.Type = ((ialogTypes)value).Obj;
		}

		public string SelfRelationLink => Obj.SelfRelationLink;

		public string AssignedDialogRelationLink => Obj.AssignedDialogRelationLink;

		public string CountRelationLink => Obj.CountRelationLink;

		public string SelectListRelationLink => Obj.SelectListRelationLink;

		public string StoreDocumentRelationLink => Obj.StoreDocumentRelationLink;

		public string TransferRelationLink => Obj.TransferRelationLink;

		public string CreateUserDefinedSearchRelationLink => Obj.CreateUserDefinedSearchRelationLink;

		public string ClientSideValidationRelationLink => Obj.ClientSideValidationRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
