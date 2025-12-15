using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AreValuesInSelectListsQuery(SDK.AreValuesInSelectListsQuery obj) : IAreValuesInSelectListsQuery
    {
        internal SDK.AreValuesInSelectListsQuery Obj { get; } = obj;

        public List<ISelectListValueToCheck> Values
        {
            get => Obj.Values.Select(x => new SelectListValueToCheck(x) as ISelectListValueToCheck).ToList();
            set => Obj.Values = value.Select(x => ((SelectListValueToCheck)x).Obj).ToList();
        }

        public List<string> SelectListIds
        {
            get => Obj.SelectListIds;
            set => Obj.SelectListIds = value;
        }

        public bool ReturnIncorrectValues
        {
            get => Obj.ReturnIncorrectValues;
            set => Obj.ReturnIncorrectValues = value;
        }
    }
}
