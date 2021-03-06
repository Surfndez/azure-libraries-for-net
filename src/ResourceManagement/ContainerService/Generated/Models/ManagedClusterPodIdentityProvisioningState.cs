// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for ManagedClusterPodIdentityProvisioningState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<ManagedClusterPodIdentityProvisioningState>))]
    public class ManagedClusterPodIdentityProvisioningState : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<ManagedClusterPodIdentityProvisioningState>
    {
        public static readonly ManagedClusterPodIdentityProvisioningState Assigned = Parse("Assigned");
        public static readonly ManagedClusterPodIdentityProvisioningState Updating = Parse("Updating");
        public static readonly ManagedClusterPodIdentityProvisioningState Deleting = Parse("Deleting");
        public static readonly ManagedClusterPodIdentityProvisioningState Failed = Parse("Failed");
    }
}
