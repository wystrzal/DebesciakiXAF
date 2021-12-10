using System;
using System.ComponentModel;
using DevExpress.ExpressApp;
using System.Collections.Generic;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.BaseImpl;

namespace Debesciaki.Module.Win
{
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class DebesciakiWindowsFormsModule : ModuleBase
    {
        private void Application_CreateCustomUserModelDifferenceStore(object sender, CreateCustomModelDifferenceStoreEventArgs e)
        {
            e.Store = new ModelDifferenceDbStore((XafApplication)sender, typeof(ModelDifference), false, "Win");
            e.Handled = true;
        }
        public DebesciakiWindowsFormsModule()
        {
            InitializeComponent();
            DevExpress.ExpressApp.Editors.FormattingProvider.UseMaskSettings = true;
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB)
        {
            return ModuleUpdater.EmptyModuleUpdaters;
        }
        public override void Setup(XafApplication application)
        {
            base.Setup(application);
            application.CreateCustomUserModelDifferenceStore += Application_CreateCustomUserModelDifferenceStore;
        }
    }
}