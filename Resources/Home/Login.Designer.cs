﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources.Home {
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
    public class Login {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Login() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.Home.Login", typeof(Login).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Don&apos;t have an account?.
        /// </summary>
        public static string DontHaveAnAccountText {
            get {
                return ResourceManager.GetString("DontHaveAnAccountText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Forgot password?.
        /// </summary>
        public static string ForgetPasswordText {
            get {
                return ResourceManager.GetString("ForgetPasswordText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username is no valid e-mailadrress..
        /// </summary>
        public static string LoginError_60020 {
            get {
                return ResourceManager.GetString("LoginError_60020", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This combination of username and password is unknown..
        /// </summary>
        public static string LoginError_60022 {
            get {
                return ResourceManager.GetString("LoginError_60022", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Perpetuality - Login.
        /// </summary>
        public static string PageTitle {
            get {
                return ResourceManager.GetString("PageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter your email.
        /// </summary>
        public static string ValidationEmailAdressRequired {
            get {
                return ResourceManager.GetString("ValidationEmailAdressRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter your password.
        /// </summary>
        public static string ValidationPasswordRequired {
            get {
                return ResourceManager.GetString("ValidationPasswordRequired", resourceCulture);
            }
        }
    }
}
