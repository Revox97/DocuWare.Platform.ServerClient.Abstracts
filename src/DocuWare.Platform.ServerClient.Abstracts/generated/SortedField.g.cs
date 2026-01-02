using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SortedField(DocuWare.Platform.ServerClient.SortedField obj) : ISortedField
    {
        internal DocuWare.Platform.ServerClient.SortedField Obj { get; } = obj;

        public string Field
        {
            get => Obj.Field;
            set => Obj.Field = value;
        }

        public SortDirection Direction
        {
            get => (SortDirection)Obj.Direction;
            set => Obj.Direction = (DocuWare.Platform.ServerClient.SortDirection)value;
        }
    }
}
