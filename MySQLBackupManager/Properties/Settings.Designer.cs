﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySQLBackupManager.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FF00FFFF")]
        public global::System.Windows.Media.Color ApplicationColor {
            get {
                return ((global::System.Windows.Media.Color)(this["ApplicationColor"]));
            }
            set {
                this["ApplicationColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Uri ApplicationTheme {
            get {
                return ((global::System.Uri)(this["ApplicationTheme"]));
            }
            set {
                this["ApplicationTheme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Large")]
        public global::FirstFloor.ModernUI.Presentation.FontSize ApplicationFontSize {
            get {
                return ((global::FirstFloor.ModernUI.Presentation.FontSize)(this["ApplicationFontSize"]));
            }
            set {
                this["ApplicationFontSize"] = value;
            }
        }
    }
}
