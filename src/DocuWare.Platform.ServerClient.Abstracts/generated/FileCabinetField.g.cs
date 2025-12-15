using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetField(SDK.FileCabinetField obj) : IFileCabinetField
    {
        internal SDK.FileCabinetField Obj { get; } = obj;

		public List<IFileCabinetFieldBase> TableFieldColumns
		{
			get => Obj.TableFieldColumns.Select(x => new FileCabinetFieldBase(x) as IFileCabinetFieldBase).ToList();
			set => Obj.TableFieldColumns = value.Select(x => ((FileCabinetFieldBase)x).Obj).ToList();
		}

		public bool UsedAsDocumentName
		{
			get => Obj.UsedAsDocumentName;
			set => Obj.UsedAsDocumentName = value;
		}

		public Link[] Links
		{
			get => Obj.Links;
			set => Obj.Links = value;
		}

		public string FixedEntry
		{
			get => Obj.FixedEntry;
			set => Obj.FixedEntry = value;
		}

		public string FieldInfoText
		{
			get => Obj.FieldInfoText;
			set => Obj.FieldInfoText = value;
		}

		public FileCabinetFieldScope Scope
		{
			get => new ileCabinetFieldScope(Obj.Scope);
			set => Obj.Scope = ((ileCabinetFieldScope)value).Obj;
		}

		public DWFieldType DWFieldType
		{
			get => new WFieldType(Obj.DWFieldType);
			set => Obj.DWFieldType = ((WFieldType)value).Obj;
		}

		public int Length
		{
			get => Obj.Length;
			set => Obj.Length = value;
		}

		public string DBFieldName
		{
			get => Obj.DBFieldName;
			set => Obj.DBFieldName = value;
		}

		public string DisplayName
		{
			get => Obj.DisplayName;
			set => Obj.DisplayName = value;
		}

		public bool DropLeadingZero
		{
			get => Obj.DropLeadingZero;
			set => Obj.DropLeadingZero = value;
		}

		public bool DropLeadingBlanks
		{
			get => Obj.DropLeadingBlanks;
			set => Obj.DropLeadingBlanks = value;
		}

		public bool NotEmpty
		{
			get => Obj.NotEmpty;
			set => Obj.NotEmpty = value;
		}

		public int Precision
		{
			get => Obj.Precision;
			set => Obj.Precision = value;
		}

		public string SelectListRelationLink => Obj.SelectListRelationLink;

		public async void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
