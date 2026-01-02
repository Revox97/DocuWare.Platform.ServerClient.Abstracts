using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SystemVariableExpression(DocuWare.Platform.ServerClient.SystemVariableExpression obj) : ISystemVariableExpression
    {
        internal DocuWare.Platform.ServerClient.SystemVariableExpression Obj { get; } = obj;

        public string VariableName
        {
            get => Obj.VariableName;
            set => Obj.VariableName = value;
        }
    }
}
