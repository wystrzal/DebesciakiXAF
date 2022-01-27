using Debesciaki.Module.Interfaces;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;

namespace Debesciaki.Module.Controllers
{
    public class NoLinkableViewController : ObjectViewController<ObjectView, INoLinkable>
    {
        private const string linkUnlinkAction = "LinkUnlinkAction";
        private LinkUnlinkController linkUnlinkController;

        protected override void OnActivated()
        {
            base.OnActivated();
            linkUnlinkController = Frame.GetController<LinkUnlinkController>();
            if (linkUnlinkController != null)
            {
                linkUnlinkController.LinkAction.Active.SetItemValue(linkUnlinkAction, false);
                linkUnlinkController.UnlinkAction.Active.SetItemValue(linkUnlinkAction, false);
            }
        }

        protected override void OnDeactivated()
        {
            if (linkUnlinkController != null)
            {
                linkUnlinkController.LinkAction.Active.RemoveItem(linkUnlinkAction);
                linkUnlinkController.UnlinkAction.Active.RemoveItem(linkUnlinkAction);
            }
            base.OnDeactivated();
        }
    }
}
