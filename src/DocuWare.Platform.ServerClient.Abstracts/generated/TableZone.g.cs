using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TableZone(SDK.TableZone obj) : ITableZone
    {
        internal SDK.TableZone Obj { get; } = obj;

        public IgridTable gridT
        {
            get => new gridTable(Obj.gridT);
            set => Obj.gridT = ((gridTable)value).Obj;
        }

        public List<ICellZone> Cz
        {
            get => Obj.Cz.Select(x => new CellZone(x) as ICellZone).ToList();
            set => Obj.Cz = value.Select(x => ((CellZone)x).Obj).ToList();
        }

        public int L
        {
            get => Obj.L;
            set => Obj.L = value;
        }

        public int T
        {
            get => Obj.T;
            set => Obj.T = value;
        }

        public int W
        {
            get => Obj.W;
            set => Obj.W = value;
        }

        public int H
        {
            get => Obj.H;
            set => Obj.H = value;
        }
    }
}
