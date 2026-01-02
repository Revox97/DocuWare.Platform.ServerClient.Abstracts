using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldMapping(DocuWare.Platform.ServerClient.FieldMapping obj) : IFieldMapping
    {
        internal DocuWare.Platform.ServerClient.FieldMapping Obj { get; } = obj;

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
