﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OLKI.Programme.ReFiDa.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool AppUpdate_CheckAtStartUp {
            get {
                return ((bool)(this["AppUpdate_CheckAtStartUp"]));
            }
            set {
                this["AppUpdate_CheckAtStartUp"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public int SearchDate_Source {
            get {
                return ((int)(this["SearchDate_Source"]));
            }
            set {
                this["SearchDate_Source"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool InstantRename {
            get {
                return ((bool)(this["InstantRename"]));
            }
            set {
                this["InstantRename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool QuitAfterRename {
            get {
                return ((bool)(this["QuitAfterRename"]));
            }
            set {
                this["QuitAfterRename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string FileSourceSelectPath {
            get {
                return ((string)(this["FileSourceSelectPath"]));
            }
            set {
                this["FileSourceSelectPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string FileSourceDirectoryPath {
            get {
                return ((string)(this["FileSourceDirectoryPath"]));
            }
            set {
                this["FileSourceDirectoryPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool FileSourceDirectorySub {
            get {
                return ((bool)(this["FileSourceDirectorySub"]));
            }
            set {
                this["FileSourceDirectorySub"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool CheckForAlreadyInTargetFormat {
            get {
                return ((bool)(this["CheckForAlreadyInTargetFormat"]));
            }
            set {
                this["CheckForAlreadyInTargetFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <string>{""Date"":""dd-MM-yyyy@HH-mm-ss"",""Position"":1,""Seperator"":"" - ""}</string>
  <string>{""Date"":""dd-MM-yyyy HH-mm-ss"",""Position"":1,""Seperator"":"" - ""}</string>
  <string>{""Date"":""dd-MM-yyyy@HH-mm"",""Position"":1,""Seperator"":"" - ""}</string>
  <string>{""Date"":""dd-MM-yyyy HH-mm"",""Position"":1,""Seperator"":"" - ""}</string>
  <string>{""Date"":""dd-MM-yyyy"",""Position"":1,""Seperator"":"" - ""}</string>
  <string>{""Date"":""dd-MM-yyyy@HH-mm-ss"",""Position"":0,""Seperator"":"" - ""}</string>
  <string>{""Date"":""dd-MM-yyyy HH-mm-ss"",""Position"":0,""Seperator"":"" - ""}</string>
  <string>{""Date"":""dd-MM-yyyy@HH-mm"",""Position"":0,""Seperator"":"" - ""}</string>
  <string>{""Date"":""dd-MM-yyyy HH-mm"",""Position"":0,""Seperator"":"" - ""}</string>
  <string>{""Date"":""dd-MM-yyyy"",""Position"":0,""Seperator"":"" - ""}</string>
</ArrayOfString>")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public global::System.Collections.Specialized.StringCollection SearchDate_List {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SearchDate_List"]));
            }
            set {
                this["SearchDate_List"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{\"Date\":\"yyyy-MM-dd@HH-mm\",\"Position\":1,\"Seperator\":\" - \"}")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public string NewDate_Format {
            get {
                return ((string)(this["NewDate_Format"]));
            }
            set {
                this["NewDate_Format"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
        public bool SelectAllRenameableFiles {
            get {
                return ((bool)(this["SelectAllRenameableFiles"]));
            }
            set {
                this["SelectAllRenameableFiles"] = value;
            }
        }
    }
}
