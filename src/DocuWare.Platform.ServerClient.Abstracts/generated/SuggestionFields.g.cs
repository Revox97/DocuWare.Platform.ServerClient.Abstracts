using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SuggestionFields(SDK.SuggestionFields obj) : ISuggestionFields
    {
        internal SDK.SuggestionFields Obj { get; } = obj;

        public List<ISuggestionField> Field
        {
            get => Obj.Field.Select(x => new SuggestionField(x) as ISuggestionField).ToList();
            set => Obj.Field = value.Select(x => ((SuggestionField)x).Obj).ToList();
        }
    }
}
