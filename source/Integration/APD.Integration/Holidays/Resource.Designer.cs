﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APD.Integration.Holidays {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("APD.Integration.Holidays.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;Holidays&gt;
        ///  &lt;Holiday date=&quot;2010-01-01&quot; description=&quot;Første nyttårsdag&quot; /&gt;
        ///  &lt;Holiday date=&quot;2010-03-28&quot; description=&quot;Palmesøndag&quot; /&gt;
        ///  &lt;Holiday date=&quot;2010-04-01&quot; description=&quot;Skjærtorsdag&quot; /&gt;
        ///  &lt;Holiday date=&quot;2010-04-02&quot; description=&quot;Langfredag&quot; /&gt;
        ///  &lt;Holiday date=&quot;2010-04-04&quot; description=&quot;Første påskedag&quot; /&gt;
        ///  &lt;Holiday date=&quot;2010-04-05&quot; description=&quot;Andre påskedag&quot; /&gt;
        ///  &lt;Holiday date=&quot;2010-05-01&quot; description=&quot;1. Mai&quot; /&gt;
        ///  &lt;Holiday date=&quot;2010-05-13&quot; descripti [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NorwegianHolidays {
            get {
                return ResourceManager.GetString("NorwegianHolidays", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;xs:element name=&quot;Holidays&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence minOccurs=&quot;0&quot; maxOccurs=&quot;unbounded&quot;&gt;
        ///        &lt;xs:element name=&quot;Holiday&quot;&gt;
        ///          &lt;xs:complexType&gt;
        ///            &lt;xs:attribute name=&quot;date&quot; type=&quot;xs:date&quot; use=&quot;required&quot; /&gt;
        ///            &lt;xs:attribute name=&quot;description&quot; type=&quot;xs:string&quot; /&gt;               
        ///          &lt;/xs:compl [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string XmlCountryHolidays {
            get {
                return ResourceManager.GetString("XmlCountryHolidays", resourceCulture);
            }
        }
    }
}
