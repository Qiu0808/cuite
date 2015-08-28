﻿using System.Threading;
using CUITe.Controls.HtmlControls;
using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.TelerikControls
{
    public class ComboBox : HtmlControl<CUITControls.HtmlDiv>
    {
        private readonly string id;
        private BrowserWindowUnderTest _window;

        public ComboBox(string searchProperties = null)
            : this(new CUITControls.HtmlDiv(), searchProperties)
        {
        }

        public ComboBox(CUITControls.HtmlDiv sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
            id = searchProperties.Trim().Split('=', '~')[1];
        }

        internal void SetWindow(BrowserWindowUnderTest window)
        {
            _window = window;
        }

        public void SelectItemByText(string sText, int milliseconds)
        {
            _window.RunScript("var obj = window.$find('" + id + "');obj.toggleDropDown();");
            Thread.Sleep(milliseconds);
            _window.RunScript("var obj = window.$find('" + id + "');obj.findItemByText('" + sText + "').select();obj.hideDropDown();");
        }
    }
}