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
    /// Defines values for Expander.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<Expander>))]
    public class Expander : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<Expander>
    {
        public static readonly Expander LeastWaste = Parse("least-waste");
        public static readonly Expander MostPods = Parse("most-pods");
        public static readonly Expander Priority = Parse("priority");
        public static readonly Expander Random = Parse("random");
    }
}
