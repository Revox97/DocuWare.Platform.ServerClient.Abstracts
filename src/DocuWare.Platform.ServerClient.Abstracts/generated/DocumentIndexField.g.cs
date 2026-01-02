using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexField(SDK.DocumentIndexField obj) : IDocumentIndexField
    {
        internal SDK.DocumentIndexField Obj { get; } = obj;

        public string FieldName
        {
            get => Obj.FieldName;
            set => Obj.FieldName = value;
        }

        public string FieldLabel
        {
            get => Obj.FieldLabel;
            set => Obj.FieldLabel = value;
        }

        public bool IsNull
        {
            get => Obj.IsNull;
            set => Obj.IsNull = value;
        }

        public bool ReadOnly
        {
            get => Obj.ReadOnly;
            set => Obj.ReadOnly = value;
        }

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }

		public string ToString() => Obj.ToString();
    }
}
