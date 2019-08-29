﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCaddins.ModelSetupWizard {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class ModelSetupWizardSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ModelSetupWizardSettings defaultInstance = ((ModelSetupWizardSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ModelSetupWizardSettings())));
        
        public static ModelSetupWizardSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>01 - Architecture;1;Workset1</string>
  <string>02 - Shared Levels and Grids;1;Shared Levels and Grids</string>
  <string>03 - Site And Landscape;1</string>
  <string>04 - SC Structure;1</string>
  <string>05 - Interiors Layouts;0</string>
  <string>06 - External Facade;1</string>
  <string>11 - Links Revit;0</string>
  <string>10 - Links DWG;0</string>
  <string>99 - Scope Boxes;0</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection DefaultWorksets {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DefaultWorksets"]));
            }
            set {
                this["DefaultWorksets"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Project Number; YYYYMMDD;^[0-9]{8}$</string>
  <string>Project Status;Preliminary</string>
  <string>Project Address;Enter Address Here</string>
  <string>Nominated Architect Number;;^[0-9]{4,5}$</string>
  <string>Orginization Name;Scott Carver Pty. Ltd.</string>
  <string>Author; Scott Carver Pty. Ltd.</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection DefaultProjectInformation {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DefaultProjectInformation"]));
            }
            set {
                this["DefaultProjectInformation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>Joe Bloggs; 1111</string>\r\n  <string>Mary Lee; 2222</string>\r\n</ArrayOfStr" +
            "ing>")]
        public global::System.Collections.Specialized.StringCollection DefaultArchitectInformation {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DefaultArchitectInformation"]));
            }
            set {
                this["DefaultArchitectInformation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Nominated Architect")]
        public string NomArchitectParamName {
            get {
                return ((string)(this["NomArchitectParamName"]));
            }
            set {
                this["NomArchitectParamName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Nominated Architect Number")]
        public string NomArchitectNoumberParamName {
            get {
                return ((string)(this["NomArchitectNoumberParamName"]));
            }
            set {
                this["NomArchitectNoumberParamName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Central Filename")]
        public string FileNameParameterName {
            get {
                return ((string)(this["FileNameParameterName"]));
            }
            set {
                this["FileNameParameterName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("J:\\Revit\\Data\\scaddins_modelsetup_config.xml")]
        public string SystemConfigFilePath {
            get {
                return ((string)(this["SystemConfigFilePath"]));
            }
            set {
                this["SystemConfigFilePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LoadSystemConfigOnStartup {
            get {
                return ((bool)(this["LoadSystemConfigOnStartup"]));
            }
            set {
                this["LoadSystemConfigOnStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Autumn;595959;59F3FF;63B8F7;7B83E5;A99A73;E6DBA5;B0DCCD;8BA559;999999;99F8FF;9FD3FA;AEB3EF;CAC1A9;EFE9C8;CFEAE0;B8C799</string>
  <string>Spring;595959;59F3FF;63B8F7;7B83E5;EDC059;E6DBA5;B0DCCE;A5D19B;999999;99F8FF;9FD3FA;AEB3EF;F4D899;EFE9C8;CFEAE1;C8E3C1</string>
  <string>Summer;595959;AA59EE;59F3FF;63B8F7;7B83E5;E6DBA5;C3C962;B0DCCE;999999;CB99F5;99F8FF;9FD3FA;AEB3EF;EFE9C8;DADE9F;CFEAE1</string>
  <string>Winter;595959;E6DBA5;B0DCCE;A5D19B;8BA559;94C1E2;7D94CE;8A92B3;999999;EFE9C8;CFEAE1;C8E3C1;B8C799;BDD9ED;AFBDE1;B7BCD1</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ColourSchemes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ColourSchemes"]));
            }
            set {
                this["ColourSchemes"] = value;
            }
        }
    }
}
