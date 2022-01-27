using Debesciaki.Module.Interfaces;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;

namespace Debesciaki.Module.Controllers
{
    public class NoLinkableViewController : ObjectViewController<ObjectView, INoLinkable>
    {
        private const string LinkUnlinkActionActive = "LinkUnlinkActionActive";
        private LinkUnlinkController linkUnlinkController;

        protected override void OnActivated()
        {
            base.OnActivated();
            linkUnlinkController = Frame.GetController<LinkUnlinkController>();
            if (linkUnlinkController != null)
            {
                linkUnlinkController.LinkAction.Active.SetItemValue(LinkUnlinkActionActive, false);
                linkUnlinkController.UnlinkAction.Active.SetItemValue(LinkUnlinkActionActive, false);
            }
        }

        protected override void OnDeactivated()
        {
            if (linkUnlinkController != null)
            {
                linkUnlinkController.LinkAction.Active.RemoveItem(LinkUnlinkActionActive);
                linkUnlinkController.UnlinkAction.Active.RemoveItem(LinkUnlinkActionActive);
            }
            base.OnDeactivated();
        }
    }
}
