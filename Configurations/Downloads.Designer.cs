﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace youtube_dl_gui.Configurations {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Downloads : global::System.Configuration.ApplicationSettingsBase {
        
        private static Downloads defaultInstance = ((Downloads)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Downloads())));
        
        public static Downloads Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string downloadPath {
            get {
                return ((string)(this["downloadPath"]));
            }
            set {
                this["downloadPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool separateDownloads {
            get {
                return ((bool)(this["separateDownloads"]));
            }
            set {
                this["separateDownloads"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SaveFormatQuality {
            get {
                return ((bool)(this["SaveFormatQuality"]));
            }
            set {
                this["SaveFormatQuality"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool deleteYtdlOnClose {
            get {
                return ((bool)(this["deleteYtdlOnClose"]));
            }
            set {
                this["deleteYtdlOnClose"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool useYtdlUpdater {
            get {
                return ((bool)(this["useYtdlUpdater"]));
            }
            set {
                this["useYtdlUpdater"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("%(title)s-%(id)s.%(ext)s")]
        public string fileNameSchema {
            get {
                return ((string)(this["fileNameSchema"]));
            }
            set {
                this["fileNameSchema"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool fixReddit {
            get {
                return ((bool)(this["fixReddit"]));
            }
            set {
                this["fixReddit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool separateIntoWebsiteURL {
            get {
                return ((bool)(this["separateIntoWebsiteURL"]));
            }
            set {
                this["separateIntoWebsiteURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SaveSubtitles {
            get {
                return ((bool)(this["SaveSubtitles"]));
            }
            set {
                this["SaveSubtitles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en")]
        public string subtitlesLanguages {
            get {
                return ((string)(this["subtitlesLanguages"]));
            }
            set {
                this["subtitlesLanguages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CloseDownloaderAfterFinish {
            get {
                return ((bool)(this["CloseDownloaderAfterFinish"]));
            }
            set {
                this["CloseDownloaderAfterFinish"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseProxy {
            get {
                return ((bool)(this["UseProxy"]));
            }
            set {
                this["UseProxy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int ProxyType {
            get {
                return ((int)(this["ProxyType"]));
            }
            set {
                this["ProxyType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyIP {
            get {
                return ((string)(this["ProxyIP"]));
            }
            set {
                this["ProxyIP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyPort {
            get {
                return ((string)(this["ProxyPort"]));
            }
            set {
                this["ProxyPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SaveThumbnail {
            get {
                return ((bool)(this["SaveThumbnail"]));
            }
            set {
                this["SaveThumbnail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SaveDescription {
            get {
                return ((bool)(this["SaveDescription"]));
            }
            set {
                this["SaveDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SaveVideoInfo {
            get {
                return ((bool)(this["SaveVideoInfo"]));
            }
            set {
                this["SaveVideoInfo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SaveAnnotations {
            get {
                return ((bool)(this["SaveAnnotations"]));
            }
            set {
                this["SaveAnnotations"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SubtitleFormat {
            get {
                return ((string)(this["SubtitleFormat"]));
            }
            set {
                this["SubtitleFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DownloadLimit {
            get {
                return ((int)(this["DownloadLimit"]));
            }
            set {
                this["DownloadLimit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int RetryAttempts {
            get {
                return ((int)(this["RetryAttempts"]));
            }
            set {
                this["RetryAttempts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int DownloadLimitType {
            get {
                return ((int)(this["DownloadLimitType"]));
            }
            set {
                this["DownloadLimitType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ForceIPv4 {
            get {
                return ((bool)(this["ForceIPv4"]));
            }
            set {
                this["ForceIPv4"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ForceIPv6 {
            get {
                return ((bool)(this["ForceIPv6"]));
            }
            set {
                this["ForceIPv6"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LimitDownloads {
            get {
                return ((bool)(this["LimitDownloads"]));
            }
            set {
                this["LimitDownloads"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EmbedSubtitles {
            get {
                return ((bool)(this["EmbedSubtitles"]));
            }
            set {
                this["EmbedSubtitles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EmbedThumbnails {
            get {
                return ((bool)(this["EmbedThumbnails"]));
            }
            set {
                this["EmbedThumbnails"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool VideoDownloadSound {
            get {
                return ((bool)(this["VideoDownloadSound"]));
            }
            set {
                this["VideoDownloadSound"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AudioDownloadAsVBR {
            get {
                return ((bool)(this["AudioDownloadAsVBR"]));
            }
            set {
                this["AudioDownloadAsVBR"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool KeepOriginalFiles {
            get {
                return ((bool)(this["KeepOriginalFiles"]));
            }
            set {
                this["KeepOriginalFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool WriteMetadata {
            get {
                return ((bool)(this["WriteMetadata"]));
            }
            set {
                this["WriteMetadata"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SkipBatchTip {
            get {
                return ((bool)(this["SkipBatchTip"]));
            }
            set {
                this["SkipBatchTip"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutomaticallyDownloadFromProtocol {
            get {
                return ((bool)(this["AutomaticallyDownloadFromProtocol"]));
            }
            set {
                this["AutomaticallyDownloadFromProtocol"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PreferFFmpeg {
            get {
                return ((bool)(this["PreferFFmpeg"]));
            }
            set {
                this["PreferFFmpeg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SeparateBatchDownloads {
            get {
                return ((bool)(this["SeparateBatchDownloads"]));
            }
            set {
                this["SeparateBatchDownloads"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AddDateToBatchDownloadFolders {
            get {
                return ((bool)(this["AddDateToBatchDownloadFolders"]));
            }
            set {
                this["AddDateToBatchDownloadFolders"] = value;
            }
        }
    }
}
