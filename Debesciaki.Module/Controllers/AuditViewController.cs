using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Linq;

namespace Debesciaki.Module.Controllers
{
    public partial class AuditViewController : ViewController
    {
        public AuditViewController()
        {
            InitializeComponent();
        }

        private void PopupWindowAuditKlienci_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            ListView lv = Application.CreateListView(Application.CreateObjectSpace(typeof(AuditDataItemPersistent)), typeof(AuditDataItemPersistent), true);
            GroupOperator criteria = new GroupOperator(GroupOperatorType.And);
            criteria.Operands.Add(new BinaryOperator("AuditedObject.TargetType", ((XPObjectSpace)ObjectSpace).Session.GetObjectType(View.CurrentObject)));
            criteria.Operands.Add(new BinaryOperator("AuditedObject.TargetKey", XPWeakReference.KeyToString(ObjectSpace.GetKeyValue(View.CurrentObject))));
            lv.CollectionSource.Criteria["ByTargetObject"] = criteria;
            e.View = lv;
        }

        private void AuditViewController_Activated(object sender, EventArgs e)
        {
            // popupWindowAudit.Active["HideShowAuditHistoryAction"] = AuditTrailService.Instance.Settings.IsTypeToAudit(View.CurrentObject.GetType()); //&& ((User)SecuritySystem.CurrentUser).IsAdministrator());
        }
    }
}
