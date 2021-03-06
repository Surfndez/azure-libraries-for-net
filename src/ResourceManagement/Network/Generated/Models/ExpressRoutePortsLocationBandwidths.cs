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
    /// ExpressRoutePorts Location Bandwidths
    /// </summary>
    /// <remarks>
    /// Real-time inventory of available ExpressRoute port bandwidths.
    /// </remarks>
    public partial class ExpressRoutePortsLocationBandwidths
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRoutePortsLocationBandwidths class.
        /// </summary>
        public ExpressRoutePortsLocationBandwidths()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRoutePortsLocationBandwidths class.
        /// </summary>
        /// <param name="offerName">Bandwidth descriptive name.</param>
        /// <param name="valueInGbps">Bandwidth value in Gbps.</param>
        public ExpressRoutePortsLocationBandwidths(string offerName = default(string), int? valueInGbps = default(int?))
        {
            OfferName = offerName;
            ValueInGbps = valueInGbps;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets bandwidth descriptive name.
        /// </summary>
        [JsonProperty(PropertyName = "offerName")]
        public string OfferName { get; private set; }

        /// <summary>
        /// Gets bandwidth value in Gbps.
        /// </summary>
        [JsonProperty(PropertyName = "valueInGbps")]
        public int? ValueInGbps { get; private set; }

    }
}
