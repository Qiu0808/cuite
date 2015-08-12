﻿using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinButton
    /// </summary>
    public class WinButton : WinControl<CUIT.WinButton>
    {
        public WinButton() : base() { }
        public WinButton(string searchParameters) : base(searchParameters) { }

        public string DisplayText 
        { 
            get { return this.UnWrap().DisplayText; } 
        }

        public string Shortcut 
        { 
            get { return this.UnWrap().Shortcut; } 
        }
    }
}