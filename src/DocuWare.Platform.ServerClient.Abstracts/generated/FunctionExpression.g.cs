using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FunctionExpression(SDK.FunctionExpression obj) : IFunctionExpression
    {
        internal SDK.FunctionExpression Obj { get; } = obj;

        public List<IAnyExpression> Parameter
        {
            get => Obj.Parameter.Select(x => new AnyExpression(x) as IAnyExpression).ToList();
            set => Obj.Parameter = value.Select(x => ((AnyExpression)x).Obj).ToList();
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }
    }
}
