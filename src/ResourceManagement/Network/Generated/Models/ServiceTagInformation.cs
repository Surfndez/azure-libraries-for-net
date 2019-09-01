// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The service tag information.
    /// </summary>
    public partial class ServiceTagInformation
    {
        /// <summary>
        /// Initializes a new instance of the ServiceTagInformation class.
        /// </summary>
        public ServiceTagInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceTagInformation class.
        /// </summary>
        /// <param name="properties">Properties of the service tag
        /// information.</param>
        /// <param name="name">The name of service tag.</param>
        /// <param name="id">The ID of service tag.</param>
        public ServiceTagInformation(ServiceTagInformationPropertiesFormat properties = default(ServiceTagInformationPropertiesFormat), string name = default(string), string id = default(string))
        {
            Properties = properties;
            Name = name;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets properties of the service tag information.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ServiceTagInformationPropertiesFormat Properties { get; private set; }

        /// <summary>
        /// Gets the name of service tag.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the ID of service tag.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}