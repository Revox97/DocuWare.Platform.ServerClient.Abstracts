using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SystemVariableExpression(SDK.SystemVariableExpression obj) : ISystemVariableExpression
    {
        internal SDK.SystemVariableExpression Obj { get; } = obj;

        public string VariableName
        {
            get => Obj.VariableName;
            set => Obj.VariableName = value;
        }
    }
}
