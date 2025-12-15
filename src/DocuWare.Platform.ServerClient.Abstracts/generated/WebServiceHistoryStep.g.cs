using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebServiceHistoryStep(SDK.WebServiceHistoryStep obj) : IWebServiceHistoryStep
    {
        internal SDK.WebServiceHistoryStep Obj { get; } = obj;

        public List<IHistoryField> Parameters
        {
            get => Obj.Parameters.Select(x => new HistoryField(x) as IHistoryField).ToList();
            set => Obj.Parameters = value.Select(x => ((HistoryField)x).Obj).ToList();
        }

        public List<IHistoryField> Results
        {
            get => Obj.Results.Select(x => new HistoryField(x) as IHistoryField).ToList();
            set => Obj.Results = value.Select(x => ((HistoryField)x).Obj).ToList();
        }

        public string Method
        {
            get => Obj.Method;
            set => Obj.Method = value;
        }
    }
}
