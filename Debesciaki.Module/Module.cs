using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Xpo;

namespace Debesciaki.Module
{
    public sealed partial class DebesciakiModule : ModuleBase
    {
        public DebesciakiModule()
        {
            InitializeComponent();
        }
        public override void CustomizeTypesInfo(ITypesInfo typesInfo)
        {
            base.CustomizeTypesInfo(typesInfo);
            CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo);
        }
    }
}
