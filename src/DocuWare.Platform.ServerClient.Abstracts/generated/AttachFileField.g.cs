using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AttachFileField(SDK.AttachFileField obj) : IAttachFileField
    {
        internal SDK.AttachFileField Obj { get; } = obj;

        public string FileTypes
        {
            get => Obj.FileTypes;
            set => Obj.FileTypes = value;
        }

        public int MaxFileSize
        {
            get => Obj.MaxFileSize;
            set => Obj.MaxFileSize = value;
        }

        public int MinFileCount
        {
            get => Obj.MinFileCount;
            set => Obj.MinFileCount = value;
        }

        public int MaxFileCount
        {
            get => Obj.MaxFileCount;
            set => Obj.MaxFileCount = value;
        }

        public bool ShowFileInfo
        {
            get => Obj.ShowFileInfo;
            set => Obj.ShowFileInfo = value;
        }

        public List<IAttachFileInfo> AttachFileInfos
        {
            get => Obj.AttachFileInfos.Select(x => new AttachFileInfo(x) as IAttachFileInfo).ToList();
            set => Obj.AttachFileInfos = value.Select(x => ((AttachFileInfo)x).Obj).ToList();
        }

        public string Value
        {
            get => Obj.Value;
            set => Obj.Value = value;
        }

        public string Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }

        public bool Hidden
        {
            get => Obj.Hidden;
            set => Obj.Hidden = value;
        }

        public bool Readonly
        {
            get => Obj.Readonly;
            set => Obj.Readonly = value;
        }

        public bool Required
        {
            get => Obj.Required;
            set => Obj.Required = value;
        }

        public string Hint
        {
            get => Obj.Hint;
            set => Obj.Hint = value;
        }

        public string ValidationID
        {
            get => Obj.ValidationID;
            set => Obj.ValidationID = value;
        }

        public string ID
        {
            get => Obj.ID;
            set => Obj.ID = value;
        }

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

        public IPosition Position
        {
            get => new Position(Obj.Position);
            set => Obj.Position = ((Position)value).Obj;
        }

        public string BehaviorID
        {
            get => Obj.BehaviorID;
            set => Obj.BehaviorID = value;
        }
    }
}
