using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BasketAreaPreferences(SDK.BasketAreaPreferences obj) : IBasketAreaPreferences
    {
        internal SDK.BasketAreaPreferences Obj { get; } = obj;

        public bool StoreDialogsBarLocked
        {
            get => Obj.StoreDialogsBarLocked;
            set => Obj.StoreDialogsBarLocked = value;
        }

        public List<IWorkInstance> Instances
        {
            get => Obj.Instances.Select(x => new WorkInstance(x) as IWorkInstance).ToList();
            set => Obj.Instances = value.Select(x => ((WorkInstance)x).Obj).ToList();
        }

        public DocuWare.Platform.ServerClient.WorkAreaType AreaType
        {
            get => Obj.AreaType;
            set => Obj.AreaType = value;
        }

        public int SelectedInstanceIndex
        {
            get => Obj.SelectedInstanceIndex;
            set => Obj.SelectedInstanceIndex = value;
        }
    }
}
