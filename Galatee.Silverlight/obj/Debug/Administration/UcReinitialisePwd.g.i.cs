#pragma checksum "C:\Users\EDMSA\Documents\Galatee\Galatee.Silverlight\Administration\UcReinitialisePwd.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "877BA779895C7B06AB3B6F51D4DD7457"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SilverlightContrib.Controls;
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


namespace Galatee.Silverlight.Administration {
    
    
    public partial class UcReinitialisePwd : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SilverlightContrib.Controls.GroupBox groupBox1_Copy1;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
        internal System.Windows.Controls.Label lbl_login;
        
        internal System.Windows.Controls.TextBox txt_Login;
        
        internal System.Windows.Controls.TextBox txt_newPwd;
        
        internal System.Windows.Controls.Label lbl_new_pwd;
        
        internal System.Windows.Controls.CheckBox ckc_Changepwd;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Galatee.Silverlight;component/Administration/UcReinitialisePwd.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.groupBox1_Copy1 = ((SilverlightContrib.Controls.GroupBox)(this.FindName("groupBox1_Copy1")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
            this.lbl_login = ((System.Windows.Controls.Label)(this.FindName("lbl_login")));
            this.txt_Login = ((System.Windows.Controls.TextBox)(this.FindName("txt_Login")));
            this.txt_newPwd = ((System.Windows.Controls.TextBox)(this.FindName("txt_newPwd")));
            this.lbl_new_pwd = ((System.Windows.Controls.Label)(this.FindName("lbl_new_pwd")));
            this.ckc_Changepwd = ((System.Windows.Controls.CheckBox)(this.FindName("ckc_Changepwd")));
        }
    }
}

