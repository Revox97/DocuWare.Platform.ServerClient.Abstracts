using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AreValuesInSelectListsResult(DocuWare.Platform.ServerClient.AreValuesInSelectListsResult obj) : IAreValuesInSelectListsResult
    {
        internal DocuWare.Platform.ServerClient.AreValuesInSelectListsResult Obj { get; } = obj;

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
