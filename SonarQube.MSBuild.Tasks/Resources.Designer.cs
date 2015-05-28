﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SonarQube.MSBuild.Tasks {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SonarQube.MSBuild.Tasks.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Config file could not be found.
        /// </summary>
        internal static string IsTest_ConfigFileNotFound {
            get {
                return ResourceManager.GetString("IsTest_ConfigFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error reading config file: {0}.
        /// </summary>
        internal static string IsTest_ErrorReadingConfigFile {
            get {
                return ResourceManager.GetString("IsTest_ErrorReadingConfigFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configured regular expression for detecting test projects is invalid.
        ///Check the &quot;{2}&quot; setting in the SonarQube portal.
        ///Expression: {0}
        ///Error: {1}.
        /// </summary>
        internal static string IsTest_InvalidRegularExpression {
            get {
                return ResourceManager.GetString("IsTest_InvalidRegularExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read the config file: {0}.
        /// </summary>
        internal static string IsTest_ReadingConfigFailed {
            get {
                return ResourceManager.GetString("IsTest_ReadingConfigFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading config file: {0} ....
        /// </summary>
        internal static string IsTest_ReadingConfigFile {
            get {
                return ResourceManager.GetString("IsTest_ReadingConfigFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Read config file successfully.
        /// </summary>
        internal static string IsTest_ReadingConfigSucceeded {
            get {
                return ResourceManager.GetString("IsTest_ReadingConfigSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using regular expression for detecting test projects from analysis config file: {0}.
        /// </summary>
        internal static string IsTest_UsingRegExFromConfig {
            get {
                return ResourceManager.GetString("IsTest_UsingRegExFromConfig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to resolve path relative to project file. Path: {0}.
        /// </summary>
        internal static string WPIF_FailedToResolvePath {
            get {
                return ResourceManager.GetString("WPIF_FailedToResolvePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project does not have a valid ProjectGuid. Analysis results for this project will not be uploaded to SonarQube. Project file: {0}.
        /// </summary>
        internal static string WPIF_MissingOrInvalidProjectGuid {
            get {
                return ResourceManager.GetString("WPIF_MissingOrInvalidProjectGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolved relative path. Path: {0}.
        /// </summary>
        internal static string WPIF_ResolvedPath {
            get {
                return ResourceManager.GetString("WPIF_ResolvedPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to resolve the file result path. Analysis type: {0}, path: {1}.
        /// </summary>
        internal static string WPIF_ResolvingRelativePath {
            get {
                return ResourceManager.GetString("WPIF_ResolvingRelativePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis setting key &quot;{0}&quot; is invalid and will be ignored.
        /// </summary>
        internal static string WPIF_WARN_InvalidSettingKey {
            get {
                return ResourceManager.GetString("WPIF_WARN_InvalidSettingKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis setting &quot;{0}&quot; does not have &quot;Value&quot; metadata and will be ignored.
        /// </summary>
        internal static string WPIF_WARN_MissingValueMetadata {
            get {
                return ResourceManager.GetString("WPIF_WARN_MissingValueMetadata", resourceCulture);
            }
        }
    }
}
