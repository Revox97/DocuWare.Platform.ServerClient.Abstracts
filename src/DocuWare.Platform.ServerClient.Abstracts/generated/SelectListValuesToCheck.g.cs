using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListValuesToCheck(SDK.SelectListValuesToCheck obj) : ISelectListValuesToCheck
    {
        internal SDK.SelectListValuesToCheck Obj { get; } = obj;

		public List<ISelectListValueToCheck> Values
		{
			get => Obj.Values.Select(x => new SelectListValueToCheck(x) as ISelectListValueToCheck).ToList();
			set => Obj.Values = value.Select(x => ((SelectListValueToCheck)x).Obj).ToList();
		}

		public bool ReturnIncorrectValues
		{
			get => Obj.ReturnIncorrectValues;
			set => Obj.ReturnIncorrectValues = value;
		}
    }
}
