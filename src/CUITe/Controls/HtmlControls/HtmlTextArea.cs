﻿using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class HtmlTextArea : HtmlControl<CUITControls.HtmlTextArea>
    {
        public HtmlTextArea() : base() { }
        public HtmlTextArea(string searchParameters) : base(searchParameters) { }

        public void SetText(string sText)
        {
            this._control.WaitForControlReady();
            this._control.Text = sText;
        }

        public string Text
        {
            get 
            {
                this._control.WaitForControlReady();
                return this._control.Text; 
            }
        }

        public bool ReadOnly
        {
            get
            {
                this._control.WaitForControlReady();
                return this._control.ReadOnly;
            }
        }
    }
}