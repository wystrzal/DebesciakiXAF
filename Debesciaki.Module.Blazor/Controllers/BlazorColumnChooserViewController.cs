using DevExpress.Blazor;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Editors.Grid;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debesciaki.Module.Blazor.Controllers
{
    public class BlazorColumnChooserViewController : ViewController<ListView>
    {
        GridListEditor gridListEditor = null;

        public BlazorColumnChooserViewController()
        {
            TargetViewNesting = Nesting.Root;
        }

        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            gridListEditor = View.Editor as GridListEditor;
            EnableColumnChooser();
        }

        protected void EnableColumnChooser()
        {
            if (gridListEditor.Control is not IDxDataGridAdapter control)
            {
                IDxDataGridAdapter dataGridAdapter = gridListEditor.GetDataGridAdapter();
                return;
            }
            control.DataGridModel.HeaderTemplate = builder =>
            {
                builder.OpenComponent<DxToolbar>(1);
                builder.AddAttribute(2, "ChildContent", (RenderFragment)((builder2) =>
                {
                    builder2.OpenComponent<DxDataGridColumnChooserToolbarItem>(3);
                    builder2.AddAttribute(0, "Alignment", ToolbarItemAlignment.Left);
                    builder2.CloseComponent();
                }));
                builder.CloseComponent();
            };
            control.DataGridSelectionColumnModel.FixedStyle = DataGridFixedStyle.Left;
        }
    }
}
