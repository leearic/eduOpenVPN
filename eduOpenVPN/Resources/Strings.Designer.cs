﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eduOpenVPN.Resources {
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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("eduOpenVPN.Resources.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to {1} (Error {0}).
        /// </summary>
        internal static string ErrorInteractiveService {
            get {
                return ResourceManager.GetString("ErrorInteractiveService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connecting to OpenVPN Interactive Service failed. Please, make sure the service is started..
        /// </summary>
        internal static string ErrorInteractiveServiceConnect {
            get {
                return ResourceManager.GetString("ErrorInteractiveServiceConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Response: {1}.
        /// </summary>
        internal static string ErrorManagementManagementResponse {
            get {
                return ResourceManager.GetString("ErrorManagementManagementResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OpenVPN Management session remote peer disconnected..
        /// </summary>
        internal static string ErrorPeerDisconnected {
            get {
                return ResourceManager.GetString("ErrorPeerDisconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OpenVPN Management reply was not expected..
        /// </summary>
        internal static string ErrorUnexpectedReply {
            get {
                return ResourceManager.GetString("ErrorUnexpectedReply", resourceCulture);
            }
        }
    }
}
