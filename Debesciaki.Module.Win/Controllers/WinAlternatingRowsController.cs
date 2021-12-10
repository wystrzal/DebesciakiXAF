using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraGrid.Views.Grid;

namespace Debesciaki.Module.Win.Controllers
{
    public partial class WinAlternatingRowsController : ViewController<ListView>
    {
        GridListEditor gridListEditor = null;
        public WinAlternatingRowsController()
        {
            InitializeComponent();
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            gridListEditor = View.Editor as GridListEditor;
            if (gridListEditor != null) { }
        }

        protected override void OnDeactivated()
        {
            if (gridListEditor != null)
            {
                gridListEditor = null;
            }
            base.OnDeactivated();
        }

        private void WinAlternatingRowsController_ViewControlsCreated(object sender, EventArgs e)
        {
            if ((View).Editor is GridListEditor listEditor)
            {
                GridView gridView = listEditor.GridView;
                SetListView(gridView);
            }
        }

        private static void SetListView(GridView gridView)
        {
            gridView.OptionsView.EnableAppearanceOddRow = true;
            gridView.OptionsView.ShowFooter = false;
            gridView.OptionsPrint.ExpandAllGroups = false;
            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.OptionsView.RowAutoHeight = true;
            gridView.OptionsView.ShowAutoFilterRow = false;
            gridView.OptionsFind.AlwaysVisible = false;
            gridView.UserCellPadding = new System.Windows.Forms.Padding(0);
            gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default;
        }
    }
}