﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoorMansTSqlFormatterNppPlugin.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.12.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase, PoorMansTSqlFormatterPluginShared.ISqlSettings {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExpandCommaLists {
            get {
                return ((bool)(this["ExpandCommaLists"]));
            }
            set {
                this["ExpandCommaLists"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TrailingCommas {
            get {
                return ((bool)(this["TrailingCommas"]));
            }
            set {
                this["TrailingCommas"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExpandBooleanExpressions {
            get {
                return ((bool)(this["ExpandBooleanExpressions"]));
            }
            set {
                this["ExpandBooleanExpressions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExpandCaseStatements {
            get {
                return ((bool)(this["ExpandCaseStatements"]));
            }
            set {
                this["ExpandCaseStatements"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExpandBetweenConditions {
            get {
                return ((bool)(this["ExpandBetweenConditions"]));
            }
            set {
                this["ExpandBetweenConditions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UppercaseKeywords {
            get {
                return ((bool)(this["UppercaseKeywords"]));
            }
            set {
                this["UppercaseKeywords"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\t")]
        public string IndentString {
            get {
                return ((string)(this["IndentString"]));
            }
            set {
                this["IndentString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UpgradeCompleted {
            get {
                return ((bool)(this["UpgradeCompleted"]));
            }
            set {
                this["UpgradeCompleted"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SpaceAfterExpandedComma {
            get {
                return ((bool)(this["SpaceAfterExpandedComma"]));
            }
            set {
                this["SpaceAfterExpandedComma"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int SpacesPerTab {
            get {
                return ((int)(this["SpacesPerTab"]));
            }
            set {
                this["SpacesPerTab"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("999")]
        public int MaxLineWidth {
            get {
                return ((int)(this["MaxLineWidth"]));
            }
            set {
                this["MaxLineWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool KeywordStandardization {
            get {
                return ((bool)(this["KeywordStandardization"]));
            }
            set {
                this["KeywordStandardization"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool BreakJoinOnSections {
            get {
                return ((bool)(this["BreakJoinOnSections"]));
            }
            set {
                this["BreakJoinOnSections"] = value;
            }
        }
    }
}
