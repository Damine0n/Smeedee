﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4913
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APD.IntegrationTests.CI.CruiseControl.Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("APD.IntegrationTests.CI.CruiseControl.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to &lt;CruiseControl&gt;
        ///  &lt;Projects&gt;
        ///    &lt;Project name=&quot;Agile Project Dashboard&quot; category=&quot;&quot; activity=&quot;Sleeping&quot; status=&quot;Stopped&quot; lastBuildStatus=&quot;Failed&quot; lastBuildLabel=&quot;0.1.0.263&quot; lastBuildTime=&quot;2009-07-02T13:14:37.9506757+02:00&quot; nextBuildTime=&quot;2009-07-02T13:19:27.5911592+02:00&quot; webUrl=&quot;http://SUMMEROFCODE/ccnet&quot; buildStage=&quot;&quot; serverName=&quot;SUMMEROFCODE&quot; /&gt;
        ///    &lt;Project name=&quot;JAMP - Just Another Mock Project&quot; category=&quot;&quot; activity=&quot;Sleeping&quot; status=&quot;Stopping&quot; lastBuildStatus=&quot;Failed&quot; lastBuildLabel=&quot;0.1.0.1&quot; last [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BuildFailed {
            get {
                return ResourceManager.GetString("BuildFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;CruiseControl&gt;
        ///  &lt;Projects&gt;
        ///    &lt;Project name=&quot;AgileProjectDashboard&quot; category=&quot;&quot; activity=&quot;Building&quot; status=&quot;Running&quot; lastBuildStatus=&quot;Failure&quot; lastBuildLabel=&quot;4&quot; lastBuildTime=&quot;2008-09-26T22:27:19.40625+02:00&quot; nextBuildTime=&quot;2008-09-26T22:35:09.96875+02:00&quot; webUrl=&quot;http://agileprojectdashboard.org/ccnet&quot; buildStage=&quot;&quot; /&gt;
        ///  &lt;/Projects&gt;
        ///  &lt;Queues&gt;
        ///    &lt;Queue name=&quot;AgileProjectDashboard&quot; /&gt;
        ///  &lt;/Queues&gt;
        ///&lt;/CruiseControl&gt;.
        /// </summary>
        internal static string Building {
            get {
                return ResourceManager.GetString("Building", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;cruisecontrol project=&quot;Agile Project Dashboard&quot;&gt;
        ///&lt;/cruisecontrol&gt;.
        /// </summary>
        internal static string empty_buildlog {
            get {
                return ResourceManager.GetString("empty_buildlog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;cruisecontrol project=&quot;JAMP - Just Another Mock Project&quot;&gt;
        ///  &lt;request source=&quot;Dashboard&quot; buildCondition=&quot;ForceBuild&quot;&gt;Dashboard triggered a build (ForceBuild)&lt;/request&gt;
        ///  &lt;modifications /&gt;
        ///  &lt;integrationProperties&gt;
        ///    &lt;CCNetArtifactDirectory&gt;d:\ccnet\AgileProjectDashboardClone\Artifacts&lt;/CCNetArtifactDirectory&gt;
        ///    &lt;CCNetBuildCondition&gt;ForceBuild&lt;/CCNetBuildCondition&gt;
        ///    &lt;CCNetBuildDate&gt;2009-07-02&lt;/CCNetBuildDate&gt;
        ///
        ///    &lt;CCNetBuildTime&gt;13:16:46&lt;/CCNetBuildTime&gt;
        ///    &lt;CCNetFailureUsers /&gt;
        ///    &lt;CCNet [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string forced_exception {
            get {
                return ResourceManager.GetString("forced_exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;cruisecontrol project=&quot;Agile Project Dashboard&quot;&gt;
        ///  &lt;request source=&quot;Dashboard&quot; buildCondition=&quot;ForceBuild&quot;&gt;Dashboard triggered a build (ForceBuild)&lt;/request&gt;
        ///  &lt;modifications /&gt;
        ///  &lt;integrationProperties&gt;
        ///    &lt;CCNetArtifactDirectory&gt;d:\ccnet\AgileProjectDashboard\Artifacts&lt;/CCNetArtifactDirectory&gt;
        ///    &lt;CCNetBuildCondition&gt;ForceBuild&lt;/CCNetBuildCondition&gt;
        ///    &lt;CCNetBuildDate&gt;2009-06-25&lt;/CCNetBuildDate&gt;
        ///
        ///    &lt;CCNetBuildTime&gt;17:30:12&lt;/CCNetBuildTime&gt;
        ///    &lt;CCNetFailureUsers&gt;
        ///      &lt;user&gt;jask&lt;/user&gt;
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string forced_failed {
            get {
                return ResourceManager.GetString("forced_failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;cruisecontrol project=&quot;Agile Project Dashboard&quot;&gt;
        ///  &lt;request source=&quot;Dashboard&quot; buildCondition=&quot;ForceBuild&quot;&gt;Dashboard triggered a build (ForceBuild)&lt;/request&gt;
        ///  &lt;modifications /&gt;
        ///  &lt;integrationProperties&gt;
        ///    &lt;CCNetArtifactDirectory&gt;d:\ccnet\AgileProjectDashboard\Artifacts&lt;/CCNetArtifactDirectory&gt;
        ///    &lt;CCNetBuildCondition&gt;ForceBuild&lt;/CCNetBuildCondition&gt;
        ///    &lt;CCNetBuildDate&gt;2009-06-21&lt;/CCNetBuildDate&gt;
        ///
        ///    &lt;CCNetBuildTime&gt;15:38:43&lt;/CCNetBuildTime&gt;
        ///    &lt;CCNetFailureUsers /&gt;
        ///    &lt;CCNetIntegrationSta [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string forced_successfull {
            get {
                return ResourceManager.GetString("forced_successfull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;CruiseControl&gt;
        ///  &lt;Projects&gt;
        ///    &lt;Project name=&quot;AgileProjectDashboard&quot; category=&quot;&quot; activity=&quot;Sleeping&quot; status=&quot;Running&quot; lastBuildStatus=&quot;invalid data&quot; lastBuildLabel=&quot;4&quot; lastBuildTime=&quot;2008-09-26T22:27:19.40625+02:00&quot; nextBuildTime=&quot;2008-09-26T22:35:09.96875+02:00&quot; webUrl=&quot;http://agileprojectdashboard.org/ccnet&quot; buildStage=&quot;&quot; /&gt;
        ///  &lt;/Projects&gt;
        ///  &lt;Queues&gt;
        ///    &lt;Queue name=&quot;AgileProjectDashboard&quot; /&gt;
        ///  &lt;/Queues&gt;
        ///&lt;/CruiseControl&gt;.
        /// </summary>
        internal static string InvalidBuildStatus {
            get {
                return ResourceManager.GetString("InvalidBuildStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;NotCruiseControl&gt;
        ///&lt;/NotCruiseControl&gt;.
        /// </summary>
        internal static string InvalidXml {
            get {
                return ResourceManager.GetString("InvalidXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to malformed as it can get.
        /// </summary>
        internal static string MalformedXml {
            get {
                return ResourceManager.GetString("MalformedXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;cruisecontrol project=&quot;Agile Project Dashboard&quot;&gt;
        ///  &lt;request source=&quot;continuous&quot; buildCondition=&quot;IfModificationExists&quot;&gt;continuous triggered a build (IfModificationExists)&lt;/request&gt;
        ///  &lt;modifications&gt;
        ///    &lt;modification type=&quot;Modified&quot;&gt;
        ///      &lt;filename&gt;BuildScript.msbuild&lt;/filename&gt;
        ///      &lt;project&gt;/trunk/source&lt;/project&gt;
        ///      &lt;date&gt;2009-06-25 16:59:24&lt;/date&gt;
        ///
        ///      &lt;user&gt;goeran&lt;/user&gt;
        ///      &lt;comment&gt;sexy fix!&lt;/comment&gt;
        ///      &lt;changeNumber&gt;338&lt;/changeNumber&gt;
        ///    &lt;/modification&gt;
        ///    &lt;modification ty [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string modified_failed {
            get {
                return ResourceManager.GetString("modified_failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;cruisecontrol project=&quot;Agile Project Dashboard&quot;&gt;
        ///  &lt;request source=&quot;continuous&quot; buildCondition=&quot;IfModificationExists&quot;&gt;continuous triggered a build (IfModificationExists)&lt;/request&gt;
        ///  &lt;modifications&gt;
        ///    &lt;modification type=&quot;Modified&quot;&gt;
        ///      &lt;filename&gt;ProjectIteration.cs&lt;/filename&gt;
        ///      &lt;project&gt;/trunk/source/APD.DomainModel.CIProject&lt;/project&gt;
        ///      &lt;date&gt;2009-06-25 15:49:09&lt;/date&gt;
        ///
        ///      &lt;user&gt;jaffe&lt;/user&gt;
        ///      &lt;comment&gt;
        ///        Made year date more modular
        ///      &lt;/comment&gt;
        ///      &lt;changeNumbe [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string modified_success {
            get {
                return ResourceManager.GetString("modified_success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;CruiseControl&gt;
        ///  &lt;Projects&gt;
        ///    &lt;Project name=&quot;AgileProjectDashboard&quot; category=&quot;&quot; activity=&quot;Sleeping&quot; status=&quot;Running&quot; lastBuildStatus=&quot;Success&quot; lastBuildLabel=&quot;0.1.00015&quot; lastBuildTime=&quot;2008-09-26T23:45:56.1875+02:00&quot; nextBuildTime=&quot;2008-09-27T01:24:12.5625+02:00&quot; webUrl=&quot;http://agileprojectdashboard.org/ccnet&quot; buildStage=&quot;&quot; /&gt;
        ///  &lt;/Projects&gt;
        ///  &lt;Queues&gt;
        ///    &lt;Queue name=&quot;AgileProjectDashboard&quot; /&gt;
        ///  &lt;/Queues&gt;
        ///&lt;/CruiseControl&gt;.
        /// </summary>
        internal static string Success {
            get {
                return ResourceManager.GetString("Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;cruisecontrol project=&quot;Agile Project Dashboard&quot;&gt;
        ///  &lt;request source=&quot;continuous&quot; buildCondition=&quot;dontknow&quot;&gt;&lt;/request&gt;
        ///  &lt;integrationProperties&gt;
        ///    &lt;CCNetArtifactDirectory&gt;d:\ccnet\AgileProjectDashboard\Artifacts&lt;/CCNetArtifactDirectory&gt;
        ///
        ///    &lt;CCNetBuildCondition&gt;dont know&lt;/CCNetBuildCondition&gt;
        ///    &lt;CCNetBuildDate&gt;2009-06-25&lt;/CCNetBuildDate&gt;
        ///    &lt;CCNetBuildTime&gt;15:49:45&lt;/CCNetBuildTime&gt;
        ///    &lt;CCNetFailureUsers /&gt;
        ///    &lt;CCNetIntegrationStatus&gt;Success&lt;/CCNetIntegrationStatus&gt;
        ///    &lt;CCNetLabel&gt;0.1.0.207 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string unknown_success {
            get {
                return ResourceManager.GetString("unknown_success", resourceCulture);
            }
        }
    }
}
