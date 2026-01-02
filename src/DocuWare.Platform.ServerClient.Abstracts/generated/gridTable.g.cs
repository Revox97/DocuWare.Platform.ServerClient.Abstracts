using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class gridTable(DocuWare.Platform.ServerClient.Content.gridTable obj) : IgridTable
    {
        internal DocuWare.Platform.ServerClient.Content.gridTable Obj { get; } = obj;

        public List<int> gridCol
        {
            get => Obj.gridCol;
            set => Obj.gridCol = value;
        }

        public List<int> gridRow
        {
            get => Obj.gridRow;
            set => Obj.gridRow = value;
        }
    }
}
