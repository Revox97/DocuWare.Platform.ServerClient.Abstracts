using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetField(DocuWare.Platform.ServerClient.FileCabinetField obj) : IFileCabinetField
    {
        internal DocuWare.Platform.ServerClient.FileCabinetField Obj { get; } = obj;

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

        public DocuWare.Platform.ServerClient.FileCabinetFieldScope Scope
        {
            get => Obj.Scope;
            set => Obj.Scope = value;
        }

        public DocuWare.Platform.ServerClient.DWFieldType DWFieldType
        {
            get => Obj.DWFieldType;
            set => Obj.DWFieldType = value;
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

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
