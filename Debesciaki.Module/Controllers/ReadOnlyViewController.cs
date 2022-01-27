using Debesciaki.Module.Interfaces;
using DevExpress.ExpressApp;

namespace Debesciaki.Module.Controllers
{
    public class ReadOnlyViewController : ObjectViewController<ObjectView, IReadOnly>
    {
        private const string AllowEdit = "CustomAllowEdit";

        protected override void OnActivated()
        {
            base.OnActivated();
            View.AllowEdit.SetItemValue(AllowEdit, false);
        }

        protected override void OnDeactivated()
        {
            View.AllowEdit.RemoveItem(AllowEdit);
            base.OnDeactivated();
        }
    }
}