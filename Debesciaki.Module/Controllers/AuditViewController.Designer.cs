namespace Debesciaki.Module.Controllers
{
    partial class AuditViewController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.popupWindowAudit = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // popupWindowAudit
            // 
            this.popupWindowAudit.AcceptButtonCaption = null;
            this.popupWindowAudit.CancelButtonCaption = null;
            this.popupWindowAudit.Caption = "Lista zmian";
            this.popupWindowAudit.ConfirmationMessage = null;
            this.popupWindowAudit.Id = "popupWindowAudit";
            this.popupWindowAudit.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.popupWindowAudit.ToolTip = null;
            this.popupWindowAudit.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.popupWindowAudit.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.PopupWindowAuditKlienci_CustomizePopupWindowParams);
            // 
            // AuditViewController
            // 
            this.Actions.Add(this.popupWindowAudit);
            this.Activated += new System.EventHandler(this.AuditViewController_Activated);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction popupWindowAudit;
    }
}
