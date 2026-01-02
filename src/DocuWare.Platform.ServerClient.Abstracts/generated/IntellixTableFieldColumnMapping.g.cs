using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntellixTableFieldColumnMapping(DocuWare.Platform.ServerClient.IntellixTableFieldColumnMapping obj) : IIntellixTableFieldColumnMapping
    {
        internal DocuWare.Platform.ServerClient.IntellixTableFieldColumnMapping Obj { get; } = obj;

        public string ColumnDBName
        {
            get => Obj.ColumnDBName;
            set => Obj.ColumnDBName = value;
        }
    }
}
