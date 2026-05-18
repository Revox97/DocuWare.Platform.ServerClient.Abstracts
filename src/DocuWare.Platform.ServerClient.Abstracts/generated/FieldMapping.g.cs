using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldMapping(DocuWare.Platform.ServerClient.FieldMapping obj) : IFieldMapping
    {
        internal DocuWare.Platform.ServerClient.FieldMapping Obj { get; } = obj;

        public List<IFieldMapping> ColumnMappings
        {
            get => Obj.ColumnMappings.Select(x => new FieldMapping(x) as IFieldMapping).ToList();
            set => Obj.ColumnMappings = value.Select(x => ((FieldMapping)x).Obj).ToList();
        }

        public string Source
        {
            get => Obj.Source;
            set => Obj.Source = value;
        }

        public string Destination
        {
            get => Obj.Destination;
            set => Obj.Destination = value;
        }
    }
}
