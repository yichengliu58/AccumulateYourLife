﻿#pragma checksum "E:\工程\AccumulateYourLife\AccumulateYourLife\PageSync.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B51C9AC49C6BB933DFFD8067D11B8A0E"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34011
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AccumulateYourLife {
    
    
    public partial class PageSync : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Canvas canvas;
        
        internal Microsoft.Phone.Controls.ToggleSwitch All;
        
        internal System.Windows.Controls.Button upload;
        
        internal System.Windows.Controls.Button download;
        
        internal System.Windows.Controls.ProgressBar progressBar;
        
        internal System.Windows.Controls.RadioButton WordOnly;
        
        internal System.Windows.Controls.RadioButton RecordOnly;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AccumulateYourLife;component/PageSync.xaml", System.UriKind.Relative));
            this.canvas = ((System.Windows.Controls.Canvas)(this.FindName("canvas")));
            this.All = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("All")));
            this.upload = ((System.Windows.Controls.Button)(this.FindName("upload")));
            this.download = ((System.Windows.Controls.Button)(this.FindName("download")));
            this.progressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar")));
            this.WordOnly = ((System.Windows.Controls.RadioButton)(this.FindName("WordOnly")));
            this.RecordOnly = ((System.Windows.Controls.RadioButton)(this.FindName("RecordOnly")));
        }
    }
}

