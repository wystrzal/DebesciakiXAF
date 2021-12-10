using Debesciaki.Module.BusinessObjects;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ConditionalAppearance;
using System.Linq;

namespace Debesciaki.Module.Controllers
{
    public class CustomApperanceViewControler : ViewController<ObjectView>
    {
        protected override void OnActivated()
        {
            base.OnActivated();

            AppearanceController appearanceController = Frame.GetController<AppearanceController>();
            if (appearanceController != null && ObjectSpace.GetType() != typeof(NonPersistentObjectSpace))
            {
                appearanceController.ResetRulesCache();
                appearanceController.CollectAppearanceRules += AppearanceController_CollectAppearanceRules;
                appearanceController.Refresh();
            }
        }

        protected override void OnDeactivated()
        {
            AppearanceController appearanceController = Frame.GetController<AppearanceController>();
            if (appearanceController != null)
            {
                appearanceController.CollectAppearanceRules -= AppearanceController_CollectAppearanceRules;
            }
            base.OnDeactivated();
        }

        private void AppearanceController_CollectAppearanceRules(object sender, CollectAppearanceRulesEventArgs e)
        {
            IQueryable<CustomApperance> customApperances = ObjectSpace.GetObjectsQuery<CustomApperance>()
                .Where(x => x.DataType == View.ObjectTypeInfo.Type);

            e.AppearanceRules.AddRange(customApperances);
        }
    }
}