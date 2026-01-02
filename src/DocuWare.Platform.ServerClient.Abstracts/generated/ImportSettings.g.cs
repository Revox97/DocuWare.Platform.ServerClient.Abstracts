using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImportSettings(DocuWare.Platform.ServerClient.ImportSettings obj) : IImportSettings
    {
        internal DocuWare.Platform.ServerClient.ImportSettings Obj { get; } = obj;

        public List<IFieldMapping> FieldMappings
        {
            get => Obj.FieldMappings.Select(x => new FieldMapping(x) as IFieldMapping).ToList();
            set => Obj.FieldMappings = value.Select(x => ((FieldMapping)x).Obj).ToList();
        }

        public bool PreserveSystemFields
        {
            get => Obj.PreserveSystemFields;
            set => Obj.PreserveSystemFields = value;
        }
    }
}
