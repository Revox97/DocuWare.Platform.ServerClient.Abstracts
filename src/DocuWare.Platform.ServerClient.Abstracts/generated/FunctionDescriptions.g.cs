using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FunctionDescriptions(SDK.FunctionDescriptions obj) : IFunctionDescriptions
    {
        internal SDK.FunctionDescriptions Obj { get; } = obj;

		public List<IFunctionDescription> Function
		{
			get => Obj.Function.Select(x => new FunctionDescription(x) as IFunctionDescription).ToList();
			set => Obj.Function = value.Select(x => ((FunctionDescription)x).Obj).ToList();
		}
    }
}
