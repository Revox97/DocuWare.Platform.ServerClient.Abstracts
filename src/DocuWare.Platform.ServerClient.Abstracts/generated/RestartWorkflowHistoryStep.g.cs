using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RestartWorkflowHistoryStep(DocuWare.Platform.ServerClient.RestartWorkflowHistoryStep obj) : IRestartWorkflowHistoryStep
    {
        internal DocuWare.Platform.ServerClient.RestartWorkflowHistoryStep Obj { get; } = obj;

        public List<IHistoryField> Fields
        {
            get => Obj.Fields.Select(x => new HistoryField(x) as IHistoryField).ToList();
            set => Obj.Fields = value.Select(x => ((HistoryField)x).Obj).ToList();
        }

        public string ErrorMessage
        {
            get => Obj.ErrorMessage;
            set => Obj.ErrorMessage = value;
        }

        public string FullErrorMessage
        {
            get => Obj.FullErrorMessage;
            set => Obj.FullErrorMessage = value;
        }
    }
}
