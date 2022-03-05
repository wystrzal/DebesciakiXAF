using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Xpo;

namespace GUS.Module
{
    public sealed partial class GUSModule : ModuleBase
    {
        public GUSModule()
        {
            InitializeComponent();
        }
        public override void Setup(XafApplication application)
        {
            base.Setup(application);
        }
        public override void CustomizeTypesInfo(ITypesInfo typesInfo)
        {
            base.CustomizeTypesInfo(typesInfo);
            CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo);
        }
    }
}