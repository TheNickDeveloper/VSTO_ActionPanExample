using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace VSTO_example
{
    public partial class CustomRibbonUI
    {
        private UserControlCustomPan _userControlCustomPan;

        private void CustomRibbonUI_Load(object sender, RibbonUIEventArgs e)
        {
            _userControlCustomPan = new UserControlCustomPan();
            Globals.ThisWorkbook.ActionsPane.Controls.Add(_userControlCustomPan);
            Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = false;
            _userControlCustomPan.Hide();
        }

        private void btnActionPan_Click(object sender, RibbonControlEventArgs e)
        {
            _userControlCustomPan.Show();
            Globals.ThisWorkbook.Application.CommandBars["Task Pane"].Position
                = Microsoft.Office.Core.MsoBarPosition.msoBarRight;
            Globals.ThisWorkbook.Application.DisplayDocumentActionTaskPane = true;
        }
    }
}
