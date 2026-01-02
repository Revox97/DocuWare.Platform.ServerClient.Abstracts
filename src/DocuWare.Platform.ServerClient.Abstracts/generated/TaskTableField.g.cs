using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskTableField(DocuWare.Platform.ServerClient.TaskTableField obj) : ITaskTableField
    {
        internal DocuWare.Platform.ServerClient.TaskTableField Obj { get; } = obj;

        public List<ITaskTableColumn> Columns
        {
            get => Obj.Columns.Select(x => new TaskTableColumn(x) as ITaskTableColumn).ToList();
            set => Obj.Columns = value.Select(x => ((TaskTableColumn)x).Obj).ToList();
        }

        public string FieldName
        {
            get => Obj.FieldName;
            set => Obj.FieldName = value;
        }

        public bool Mandatory
        {
            get => Obj.Mandatory;
            set => Obj.Mandatory = value;
        }

        public bool IsReadOnly
        {
            get => Obj.IsReadOnly;
            set => Obj.IsReadOnly = value;
        }

        public FormTypeEnum FormFieldType
        {
            get => (FormTypeEnum)Obj.FormFieldType;
            set => Obj.FormFieldType = (DocuWare.Platform.ServerClient.FormTypeEnum)value;
        }

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
