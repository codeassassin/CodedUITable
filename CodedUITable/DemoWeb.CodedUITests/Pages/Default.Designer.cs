﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace DemoWeb.CodedUITests.Pages.DefaultClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60610.1")]
    public partial class Default
    {
        
        #region Properties
        public UIDemoWebWindowsInternWindow UIDemoWebWindowsInternWindow
        {
            get
            {
                if ((this.mUIDemoWebWindowsInternWindow == null))
                {
                    this.mUIDemoWebWindowsInternWindow = new UIDemoWebWindowsInternWindow();
                }
                return this.mUIDemoWebWindowsInternWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIDemoWebWindowsInternWindow mUIDemoWebWindowsInternWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60610.1")]
    public class UIDemoWebWindowsInternWindow : BrowserWindow
    {
        
        public UIDemoWebWindowsInternWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "DemoWeb";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("DemoWeb");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIDemoWebDocument UIDemoWebDocument
        {
            get
            {
                if ((this.mUIDemoWebDocument == null))
                {
                    this.mUIDemoWebDocument = new UIDemoWebDocument(this);
                }
                return this.mUIDemoWebDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIDemoWebDocument mUIDemoWebDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60610.1")]
    public class UIDemoWebDocument : HtmlDocument
    {
        
        public UIDemoWebDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "DemoWeb";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:16330/";
            this.WindowTitles.Add("DemoWeb");
            #endregion
        }
        
        #region Properties
        public HtmlTable UITheTable
        {
            get
            {
                if ((this.mUITheTable == null))
                {
                    this.mUITheTable = new HtmlTable(this);
                    #region Search Criteria
                    this.mUITheTable.SearchProperties[HtmlTable.PropertyNames.Id] = "theTable";
                    this.mUITheTable.SearchProperties[HtmlTable.PropertyNames.Name] = null;
                    this.mUITheTable.FilterProperties[HtmlTable.PropertyNames.InnerText] = "Col1\r\n\r\nCol2\r\n\r\n\r\nHelloBuy";
                    this.mUITheTable.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "id=\"theTable\"";
                    this.mUITheTable.FilterProperties[HtmlTable.PropertyNames.RowCount] = "2";
                    this.mUITheTable.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "2";
                    this.mUITheTable.FilterProperties[HtmlTable.PropertyNames.Class] = null;
                    this.mUITheTable.FilterProperties[HtmlTable.PropertyNames.TagInstance] = "1";
                    this.mUITheTable.WindowTitles.Add("DemoWeb");
                    #endregion
                }
                return this.mUITheTable;
            }
        }
        #endregion
        
        #region Fields
        private HtmlTable mUITheTable;
        #endregion
    }
}
