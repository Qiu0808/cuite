﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;

namespace CUITe.Controls.SilverlightControls
{
    public class CUITe_SlCheckBox : CUITe_ControlBase<SilverlightCheckBox>
    {
        public CUITe_SlCheckBox() : base() { }
        public CUITe_SlCheckBox(string sSearchParameters) : base(sSearchParameters) { }

        public void Check()
        {
            this._control.WaitForControlReady();
            if (!this._control.Checked)
            {
                this._control.Checked = true;
            }
        }

        public void UnCheck()
        {
            this._control.WaitForControlReady();
            if (this._control.Checked)
            {
                this._control.Checked = false;
            }
        }

        public bool Checked
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.Checked;
            }
        }
    }
}