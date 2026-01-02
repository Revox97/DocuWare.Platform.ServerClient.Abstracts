using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NumericHistoryFieldOptions(DocuWare.Platform.ServerClient.NumericHistoryFieldOptions obj) : INumericHistoryFieldOptions
    {
        internal DocuWare.Platform.ServerClient.NumericHistoryFieldOptions Obj { get; } = obj;

        public int Precision
        {
            get => Obj.Precision;
            set => Obj.Precision = value;
        }
    }
}
