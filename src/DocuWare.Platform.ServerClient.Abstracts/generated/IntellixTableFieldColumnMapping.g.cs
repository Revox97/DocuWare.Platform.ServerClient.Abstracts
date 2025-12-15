using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntellixTableFieldColumnMapping(SDK.IntellixTableFieldColumnMapping obj) : IIntellixTableFieldColumnMapping
    {
        internal SDK.IntellixTableFieldColumnMapping Obj { get; } = obj;

        public string ColumnDBName
        {
            get => Obj.ColumnDBName;
            set => Obj.ColumnDBName = value;
        }
    }
}
