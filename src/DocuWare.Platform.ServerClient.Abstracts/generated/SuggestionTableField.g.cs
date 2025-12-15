using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SuggestionTableField(SDK.SuggestionTableField obj) : ISuggestionTableField
    {
        internal SDK.SuggestionTableField Obj { get; } = obj;

        public List<ISuggestionTable> Table
        {
            get => Obj.Table.Select(x => new SuggestionTable(x) as ISuggestionTable).ToList();
            set => Obj.Table = value.Select(x => ((SuggestionTable)x).Obj).ToList();
        }

        public string DBName
        {
            get => Obj.DBName;
            set => Obj.DBName = value;
        }

        public DocuWare.Platform.ServerClient.IntellixFieldTrust Confidence
        {
            get => Obj.Confidence;
            set => Obj.Confidence = value;
        }
    }
}
