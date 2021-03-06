// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------


namespace System.CodeDom.Compiler
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), Inherited = false, AllowMultiple = false)]
    public sealed partial class GeneratedCodeAttribute : System.Attribute
    {
        public GeneratedCodeAttribute(string tool, string version) { }
        public string Tool { get { return default(string); } }
        public string Version { get { return default(string); } }
    }
}
namespace System.Diagnostics.CodeAnalysis
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), Inherited = false, AllowMultiple = true)]
    [System.Diagnostics.ConditionalAttribute("CODE_ANALYSIS")]
    public sealed partial class SuppressMessageAttribute : System.Attribute
    {
        public SuppressMessageAttribute(string category, string checkId) { }
        public string Category { get { return default(string); } }
        public string CheckId { get { return default(string); } }
        public string Justification { get { return default(string); } set { } }
        public string MessageId { get { return default(string); } set { } }
        public string Scope { get { return default(string); } set { } }
        public string Target { get { return default(string); } set { } }
    }
}
