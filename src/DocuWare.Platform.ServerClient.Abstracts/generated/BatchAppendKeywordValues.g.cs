using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchAppendKeywordValues(DocuWare.Platform.ServerClient.BatchAppendKeywordValues obj) : IBatchAppendKeywordValues
    {
        internal DocuWare.Platform.ServerClient.BatchAppendKeywordValues Obj { get; } = obj;

        public List<int> DocId
        {
            get => Obj.DocId;
            set => Obj.DocId = value;
        }

        public List<string> Keyword
        {
            get => Obj.Keyword;
            set => Obj.Keyword = value;
        }

        public string FieldName
        {
            get => Obj.FieldName;
            set => Obj.FieldName = value;
        }

        public bool BreakOnError
        {
            get => Obj.BreakOnError;
            set => Obj.BreakOnError = value;
        }

        public string StoreDialogId
        {
            get => Obj.StoreDialogId;
            set => Obj.StoreDialogId = value;
        }

        public bool ForceUpdate
        {
            get => Obj.ForceUpdate;
            set => Obj.ForceUpdate = value;
        }
    }
}
