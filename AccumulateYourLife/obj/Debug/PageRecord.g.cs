﻿#pragma checksum "C:\Users\Jay Jay\Desktop\AccumulateYourLife 3.20\AccumulateYourLife\AccumulateYourLife\PageRecord.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3023AF6EB8D59DE4FB8AA1458103B422"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.33440
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
    
    
    public partial class PageRecord : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock textBlockTitle;
        
        internal System.Windows.Controls.TextBlock textBlockSetTime;
        
        internal System.Windows.Controls.Image image;
        
        internal System.Windows.Controls.TextBlock textBlockContent;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AccumulateYourLife;component/PageRecord.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.textBlockTitle = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockTitle")));
            this.textBlockSetTime = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockSetTime")));
            this.image = ((System.Windows.Controls.Image)(this.FindName("image")));
            this.textBlockContent = ((System.Windows.Controls.TextBlock)(this.FindName("textBlockContent")));
        }
    }
}
