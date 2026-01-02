using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldMappings(DocuWare.Platform.ServerClient.FieldMappings obj) : IFieldMappings
    {
        internal DocuWare.Platform.ServerClient.FieldMappings Obj { get; } = obj;

        public List<IFieldMapping> Mapping
        {
            get => Obj.Mapping.Select(x => new FieldMapping(x) as IFieldMapping).ToList();
            set => Obj.Mapping = value.Select(x => ((FieldMapping)x).Obj).ToList();
        }
    }
}
