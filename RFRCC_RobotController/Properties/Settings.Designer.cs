﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RFRCC_RobotController.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\PlasmaData.md" +
            "f;Integrated Security=True;Connect Timeout=30")]
        public string PlasmaDataConnectionString {
            get {
                return ((string)(this["PlasmaDataConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LoadSequenceEnabled {
            get {
                return ((bool)(this["LoadSequenceEnabled"]));
            }
            set {
                this["LoadSequenceEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LocationSequenceEnabled {
            get {
                return ((bool)(this["LocationSequenceEnabled"]));
            }
            set {
                this["LocationSequenceEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EGMEnabled {
            get {
                return ((bool)(this["EGMEnabled"]));
            }
            set {
                this["EGMEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IHSEnabled {
            get {
                return ((bool)(this["IHSEnabled"]));
            }
            set {
                this["IHSEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool HitchfeedingEnabled {
            get {
                return ((bool)(this["HitchfeedingEnabled"]));
            }
            set {
                this["HitchfeedingEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ImportAssignCustomSectors {
            get {
                return ((bool)(this["ImportAssignCustomSectors"]));
            }
            set {
                this["ImportAssignCustomSectors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ImportStartAlignedWithFace {
            get {
                return ((bool)(this["ImportStartAlignedWithFace"]));
            }
            set {
                this["ImportStartAlignedWithFace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public decimal ImportNumberOfSectors {
            get {
                return ((decimal)(this["ImportNumberOfSectors"]));
            }
            set {
                this["ImportNumberOfSectors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportNWMin {
            get {
                return ((decimal)(this["ImportNWMin"]));
            }
            set {
                this["ImportNWMin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportNWMax {
            get {
                return ((decimal)(this["ImportNWMax"]));
            }
            set {
                this["ImportNWMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportNMin {
            get {
                return ((decimal)(this["ImportNMin"]));
            }
            set {
                this["ImportNMin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportNMax {
            get {
                return ((decimal)(this["ImportNMax"]));
            }
            set {
                this["ImportNMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportNEMin {
            get {
                return ((decimal)(this["ImportNEMin"]));
            }
            set {
                this["ImportNEMin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportNEMax {
            get {
                return ((decimal)(this["ImportNEMax"]));
            }
            set {
                this["ImportNEMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportEMin {
            get {
                return ((decimal)(this["ImportEMin"]));
            }
            set {
                this["ImportEMin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportEMax {
            get {
                return ((decimal)(this["ImportEMax"]));
            }
            set {
                this["ImportEMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportSEMin {
            get {
                return ((decimal)(this["ImportSEMin"]));
            }
            set {
                this["ImportSEMin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportSEMax {
            get {
                return ((decimal)(this["ImportSEMax"]));
            }
            set {
                this["ImportSEMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportSMin {
            get {
                return ((decimal)(this["ImportSMin"]));
            }
            set {
                this["ImportSMin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportSMax {
            get {
                return ((decimal)(this["ImportSMax"]));
            }
            set {
                this["ImportSMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportSWMin {
            get {
                return ((decimal)(this["ImportSWMin"]));
            }
            set {
                this["ImportSWMin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportSWMax {
            get {
                return ((decimal)(this["ImportSWMax"]));
            }
            set {
                this["ImportSWMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportWMin {
            get {
                return ((decimal)(this["ImportWMin"]));
            }
            set {
                this["ImportWMin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal ImportWMax {
            get {
                return ((decimal)(this["ImportWMax"]));
            }
            set {
                this["ImportWMax"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool GenerationHoleLeadInOutEnabled {
            get {
                return ((bool)(this["GenerationHoleLeadInOutEnabled"]));
            }
            set {
                this["GenerationHoleLeadInOutEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool GenerationExtContourLeadInOutEnabled {
            get {
                return ((bool)(this["GenerationExtContourLeadInOutEnabled"]));
            }
            set {
                this["GenerationExtContourLeadInOutEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool GenerationIntContourLeadInOutEnabled {
            get {
                return ((bool)(this["GenerationIntContourLeadInOutEnabled"]));
            }
            set {
                this["GenerationIntContourLeadInOutEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public decimal GenerationHoleLeadInDist {
            get {
                return ((decimal)(this["GenerationHoleLeadInDist"]));
            }
            set {
                this["GenerationHoleLeadInDist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public decimal GenerationHoleLeadOutDist {
            get {
                return ((decimal)(this["GenerationHoleLeadOutDist"]));
            }
            set {
                this["GenerationHoleLeadOutDist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public decimal GenerationExtContourLeadInDist {
            get {
                return ((decimal)(this["GenerationExtContourLeadInDist"]));
            }
            set {
                this["GenerationExtContourLeadInDist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public decimal GenerationExtContourLeadOutDist {
            get {
                return ((decimal)(this["GenerationExtContourLeadOutDist"]));
            }
            set {
                this["GenerationExtContourLeadOutDist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public decimal GenerationIntContourLeadInDist {
            get {
                return ((decimal)(this["GenerationIntContourLeadInDist"]));
            }
            set {
                this["GenerationIntContourLeadInDist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public decimal GenerationIntContourLeadOutDist {
            get {
                return ((decimal)(this["GenerationIntContourLeadOutDist"]));
            }
            set {
                this["GenerationIntContourLeadOutDist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool GenerationHoleLinearLeadIn {
            get {
                return ((bool)(this["GenerationHoleLinearLeadIn"]));
            }
            set {
                this["GenerationHoleLinearLeadIn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool GenerationExtContourLinearLeadIn {
            get {
                return ((bool)(this["GenerationExtContourLinearLeadIn"]));
            }
            set {
                this["GenerationExtContourLinearLeadIn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool GenerationIntContourLinearLeadIn {
            get {
                return ((bool)(this["GenerationIntContourLinearLeadIn"]));
            }
            set {
                this["GenerationIntContourLinearLeadIn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12.00")]
        public decimal ImportDefaultStockLength {
            get {
                return ((decimal)(this["ImportDefaultStockLength"]));
            }
            set {
                this["ImportDefaultStockLength"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal GenerationOpSettingsHoleApproxDist {
            get {
                return ((decimal)(this["GenerationOpSettingsHoleApproxDist"]));
            }
            set {
                this["GenerationOpSettingsHoleApproxDist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal GenerationOpExtContourApproxDist {
            get {
                return ((decimal)(this["GenerationOpExtContourApproxDist"]));
            }
            set {
                this["GenerationOpExtContourApproxDist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal GenerationOpSettingsIntContourApproxDist {
            get {
                return ((decimal)(this["GenerationOpSettingsIntContourApproxDist"]));
            }
            set {
                this["GenerationOpSettingsIntContourApproxDist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal GenerationOpSettingsExtContourApproxDist {
            get {
                return ((decimal)(this["GenerationOpSettingsExtContourApproxDist"]));
            }
            set {
                this["GenerationOpSettingsExtContourApproxDist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal GenerationOpSettingsExtContourAccel {
            get {
                return ((decimal)(this["GenerationOpSettingsExtContourAccel"]));
            }
            set {
                this["GenerationOpSettingsExtContourAccel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal GenerationOpSettingsHoleAccel {
            get {
                return ((decimal)(this["GenerationOpSettingsHoleAccel"]));
            }
            set {
                this["GenerationOpSettingsHoleAccel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal GenerationOpSettingsIntContourAccel {
            get {
                return ((decimal)(this["GenerationOpSettingsIntContourAccel"]));
            }
            set {
                this["GenerationOpSettingsIntContourAccel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PathCorrectionEnabled {
            get {
                return ((bool)(this["PathCorrectionEnabled"]));
            }
            set {
                this["PathCorrectionEnabled"] = value;
            }
        }
    }
}
