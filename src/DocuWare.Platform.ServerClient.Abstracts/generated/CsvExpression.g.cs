using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CsvExpression(DocuWare.Platform.ServerClient.CsvExpression obj) : ICsvExpression
    {
        internal DocuWare.Platform.ServerClient.CsvExpression Obj { get; } = obj;

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
