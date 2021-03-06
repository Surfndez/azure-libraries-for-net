// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for VirtualNetworkRuleState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<VirtualNetworkRuleState>))]
    public class VirtualNetworkRuleState : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<VirtualNetworkRuleState>
    {
        public static readonly VirtualNetworkRuleState Initializing = Parse("Initializing");
        public static readonly VirtualNetworkRuleState InProgress = Parse("InProgress");
        public static readonly VirtualNetworkRuleState Ready = Parse("Ready");
        public static readonly VirtualNetworkRuleState Deleting = Parse("Deleting");
        public static readonly VirtualNetworkRuleState Unknown = Parse("Unknown");
    }
}
