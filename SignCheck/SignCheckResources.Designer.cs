﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SignCheck {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SignCheckResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SignCheckResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SignCheck.SignCheckResources", typeof(SignCheckResources).Assembly);
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
        ///   Looks up a localized string similar to All files are signed..
        /// </summary>
        internal static string scAllFilesSigned {
            get {
                return ResourceManager.GetString("scAllFilesSigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find {0}..
        /// </summary>
        internal static string scCannotFindFile {
            get {
                return ResourceManager.GetString("scCannotFindFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting --file-status to {0}..
        /// </summary>
        internal static string scDetailFileStatusSetting {
            get {
                return ResourceManager.GetString("scDetailFileStatusSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find exclusion file: {0}..
        /// </summary>
        internal static string scErrorCannotFindExclusionFile {
            get {
                return ResourceManager.GetString("scErrorCannotFindExclusionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown value for --file-status: {0}..
        /// </summary>
        internal static string scErrorUnknownFileStatus {
            get {
                return ResourceManager.GetString("scErrorUnknownFileStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to locate {0}..
        /// </summary>
        internal static string scInputFileDoesNotExist {
            get {
                return ResourceManager.GetString("scInputFileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No files were processed..
        /// </summary>
        internal static string scNoFilesProcessed {
            get {
                return ResourceManager.GetString("scNoFilesProcessed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing exclusions list in {0}.
        /// </summary>
        internal static string scProcessExclusions {
            get {
                return ResourceManager.GetString("scProcessExclusions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Results.
        /// </summary>
        internal static string scResults {
            get {
                return ResourceManager.GetString("scResults", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total Files: {0} Signed: {1} Unsigned: {2} Skipped: {3} Excluded: {4}.
        /// </summary>
        internal static string scStats {
            get {
                return ResourceManager.GetString("scStats", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string scSummary {
            get {
                return ResourceManager.GetString("scSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are unsigned files..
        /// </summary>
        internal static string scUnsignedFiles {
            get {
                return ResourceManager.GetString("scUnsignedFiles", resourceCulture);
            }
        }
    }
}
