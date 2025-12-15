using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkflowStampsSettings(SDK.WorkflowStampsSettings obj) : IWorkflowStampsSettings
    {
        internal SDK.WorkflowStampsSettings Obj { get; } = obj;

        public IFont InfoFontFamily
        {
            get => new Font(Obj.InfoFontFamily);
            set => Obj.InfoFontFamily = ((Font)value).Obj;
        }

        public IFont StampFont
        {
            get => new Font(Obj.StampFont);
            set => Obj.StampFont = ((Font)value).Obj;
        }

        public bool UseFrame
        {
            get => Obj.UseFrame;
            set => Obj.UseFrame = value;
        }

        public bool UseDate
        {
            get => Obj.UseDate;
            set => Obj.UseDate = value;
        }

        public bool UseTime
        {
            get => Obj.UseTime;
            set => Obj.UseTime = value;
        }

        public bool IsSignature
        {
            get => Obj.IsSignature;
            set => Obj.IsSignature = value;
        }

        public bool UseUserName
        {
            get => Obj.UseUserName;
            set => Obj.UseUserName = value;
        }

        public bool UseDecisionName
        {
            get => Obj.UseDecisionName;
            set => Obj.UseDecisionName = value;
        }

        public bool UseActivityName
        {
            get => Obj.UseActivityName;
            set => Obj.UseActivityName = value;
        }
    }
}
