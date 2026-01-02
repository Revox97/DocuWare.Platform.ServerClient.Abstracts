using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UpdateIndexFieldsInfo(SDK.UpdateIndexFieldsInfo obj) : IUpdateIndexFieldsInfo
    {
        internal SDK.UpdateIndexFieldsInfo Obj { get; } = obj;

        public string DialogId
        {
            get => Obj.DialogId;
            set => Obj.DialogId = value;
        }

        public bool NormalizeCoordinates
        {
            get => Obj.NormalizeCoordinates;
            set => Obj.NormalizeCoordinates = value;
        }

        public bool ForceUpdate
        {
            get => Obj.ForceUpdate;
            set => Obj.ForceUpdate = value;
        }

        public List<IDocumentIndexField> Field
        {
            get => Obj.Field.Select(x => new DocumentIndexField(x) as IDocumentIndexField).ToList();
            set => Obj.Field = value.Select(x => ((DocumentIndexField)x).Obj).ToList();
        }
    }
}
