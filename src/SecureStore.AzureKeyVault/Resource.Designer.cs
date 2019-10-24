﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AzureKeyVault.SecureStore {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AzureKeyVault.SecureStore.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Azure Key Vault json is invalid or is missing..
        /// </summary>
        internal static string AzureKeyVaultJsonInvalidOrMissing {
            get {
                return ResourceManager.GetString("AzureKeyVaultJsonInvalidOrMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Azure Key Vault setting {0} is invalid or is missing..
        /// </summary>
        internal static string AzureKeyVaultSettingInvalidOrMissing {
            get {
                return ResourceManager.GetString("AzureKeyVaultSettingInvalidOrMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Secure store credentials are invalid..
        /// </summary>
        internal static string InvalidSecureStoreCredentials {
            get {
                return ResourceManager.GetString("InvalidSecureStoreCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Null or empty secret name.
        /// </summary>
        internal static string InvalidSecureStoreSecretName {
            get {
                return ResourceManager.GetString("InvalidSecureStoreSecretName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Secure store operation {0} is not authorized..
        /// </summary>
        internal static string SecureStoreOperationNotAuthorizeded {
            get {
                return ResourceManager.GetString("SecureStoreOperationNotAuthorizeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Secret not found..
        /// </summary>
        internal static string SecureStoreSecretNotFound {
            get {
                return ResourceManager.GetString("SecureStoreSecretNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client Id.
        /// </summary>
        internal static string SettingClientId {
            get {
                return ResourceManager.GetString("SettingClientId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client Secret.
        /// </summary>
        internal static string SettingClientSecret {
            get {
                return ResourceManager.GetString("SettingClientSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key Vault Uri.
        /// </summary>
        internal static string SettingKeyVaultUri {
            get {
                return ResourceManager.GetString("SettingKeyVaultUri", resourceCulture);
            }
        }
    }
}
