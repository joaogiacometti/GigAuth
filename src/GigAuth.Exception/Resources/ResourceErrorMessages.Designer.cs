﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GigAuth.Exception.Resources {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ResourceErrorMessages {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceErrorMessages() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("GigAuth.Exception.Resources.ResourceErrorMessages", typeof(ResourceErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string INVALID_PASSWORD {
            get {
                return ResourceManager.GetString("INVALID_PASSWORD", resourceCulture);
            }
        }
        
        public static string USER_NAME_EMPTY {
            get {
                return ResourceManager.GetString("USER_NAME_EMPTY", resourceCulture);
            }
        }
        
        public static string USER_NAME_TOO_SHORT {
            get {
                return ResourceManager.GetString("USER_NAME_TOO_SHORT", resourceCulture);
            }
        }
        
        public static string USER_NAME_TOO_LONG {
            get {
                return ResourceManager.GetString("USER_NAME_TOO_LONG", resourceCulture);
            }
        }
        
        public static string EMAIL_EMPTY {
            get {
                return ResourceManager.GetString("EMAIL_EMPTY", resourceCulture);
            }
        }
        
        public static string EMAIL_INVALID {
            get {
                return ResourceManager.GetString("EMAIL_INVALID", resourceCulture);
            }
        }
        
        public static string EMAIL_TOO_LONG {
            get {
                return ResourceManager.GetString("EMAIL_TOO_LONG", resourceCulture);
            }
        }
        
        public static string USER_NAME_ALREADY_USED {
            get {
                return ResourceManager.GetString("USER_NAME_ALREADY_USED", resourceCulture);
            }
        }
        
        public static string UNKNOWN_ERROR {
            get {
                return ResourceManager.GetString("UNKNOWN_ERROR", resourceCulture);
            }
        }
        
        public static string INVALID_CREDENTIALS {
            get {
                return ResourceManager.GetString("INVALID_CREDENTIALS", resourceCulture);
            }
        }
        
        public static string USER_NOT_FOUND {
            get {
                return ResourceManager.GetString("USER_NOT_FOUND", resourceCulture);
            }
        }
        
        public static string TOKEN_EMPTY {
            get {
                return ResourceManager.GetString("TOKEN_EMPTY", resourceCulture);
            }
        }
        
        public static string TOKEN_NOT_FOUND {
            get {
                return ResourceManager.GetString("TOKEN_NOT_FOUND", resourceCulture);
            }
        }
        
        public static string TOKEN_EXPIRED {
            get {
                return ResourceManager.GetString("TOKEN_EXPIRED", resourceCulture);
            }
        }
    }
}
