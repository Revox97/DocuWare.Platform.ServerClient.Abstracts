using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CsvExpression(SDK.CsvExpression obj) : ICsvExpression
    {
        internal SDK.CsvExpression Obj { get; } = obj;

        public string Delimiter
        {
            get => Obj.Delimiter;
            set => Obj.Delimiter = value;
        }

        public bool IsUtc
        {
            get => Obj.IsUtc;
            set => Obj.IsUtc = value;
        }
    }
}
