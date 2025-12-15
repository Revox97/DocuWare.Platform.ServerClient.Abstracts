using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SuggestionTableFields(SDK.SuggestionTableFields obj) : ISuggestionTableFields
    {
        internal SDK.SuggestionTableFields Obj { get; } = obj;

        public List<ISuggestionTableField> TableField
        {
            get => Obj.TableField.Select(x => new SuggestionTableField(x) as ISuggestionTableField).ToList();
            set => Obj.TableField = value.Select(x => ((SuggestionTableField)x).Obj).ToList();
        }
    }
}
