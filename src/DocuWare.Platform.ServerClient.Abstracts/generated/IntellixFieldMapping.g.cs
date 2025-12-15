using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntellixFieldMapping(SDK.IntellixFieldMapping obj) : IIntellixFieldMapping
    {
        internal SDK.IntellixFieldMapping Obj { get; } = obj;

        public string FieldDBName
        {
            get => Obj.FieldDBName;
            set => Obj.FieldDBName = value;
        }

        public string IntellixFieldName
        {
            get => Obj.IntellixFieldName;
            set => Obj.IntellixFieldName = value;
        }
    }
}
