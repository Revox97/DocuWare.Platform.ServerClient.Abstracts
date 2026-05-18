using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AreValuesInSelectListsResult(SDK.AreValuesInSelectListsResult obj) : IAreValuesInSelectListsResult
    {
        internal SDK.AreValuesInSelectListsResult Obj { get; } = obj;

        public bool Result
        {
            get => Obj.Result;
            set => Obj.Result = value;
        }

        public List<ISelectListValueToCheck> IncorrectValues
        {
            get => Obj.IncorrectValues.Select(x => new SelectListValueToCheck(x) as ISelectListValueToCheck).ToList();
            set => Obj.IncorrectValues = value.Select(x => ((SelectListValueToCheck)x).Obj).ToList();
        }
    }
}
