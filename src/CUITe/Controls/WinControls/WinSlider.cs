﻿using CUITControls = Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinSlider
    /// </summary>
    public class WinSlider : WinControl<CUITControls.WinSlider>
    {
        public WinSlider(string searchProperties = null)
            : this(new CUITControls.WinSlider(), searchProperties)
        {
        }

        public WinSlider(CUITControls.WinSlider sourceControl, string searchProperties = null)
            : base(sourceControl, searchProperties)
        {
        }

        public double LineSize
        {
            get { return SourceControl.LineSize; }
        }

        public double MaximumPosition
        {
            get { return SourceControl.MaximumPosition; }
        }

        public double MinimumPosition
        {
            get { return SourceControl.MinimumPosition; }
        }

        public double PageSize
        {
            get { return SourceControl.PageSize; }
        }

        public double Position
        {
            get { return SourceControl.Position; }
            set { SourceControl.Position = value; }
        }

        public string PositionAsString
        {
            get { return SourceControl.PositionAsString; }
            set { SourceControl.PositionAsString = value; }
        }

        public double TickCount
        {
            get { return SourceControl.TickCount; }
        }

        public double TickPosition
        {
            get { return SourceControl.TickPosition; }
        }

        public double TickValue
        {
            get { return SourceControl.TickValue; }
        }
    }
}