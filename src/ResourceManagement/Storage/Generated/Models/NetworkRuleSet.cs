// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Network rule set
    /// </summary>
    public partial class NetworkRuleSet
    {
        /// <summary>
        /// Initializes a new instance of the NetworkRuleSet class.
        /// </summary>
        public NetworkRuleSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkRuleSet class.
        /// </summary>
        /// <param name="defaultAction">Specifies the default action of allow
        /// or deny when no other rules match. Possible values include:
        /// 'Allow', 'Deny'</param>
        /// <param name="bypass">Specifies whether traffic is bypassed for
        /// Logging/Metrics/AzureServices. Possible values are any combination
        /// of Logging|Metrics|AzureServices (For example, "Logging, Metrics"),
        /// or None to bypass none of those traffics. Possible values include:
        /// 'None', 'Logging', 'Metrics', 'AzureServices'</param>
        /// <param name="virtualNetworkRules">Sets the virtual network
        /// rules</param>
        /// <param name="ipRules">Sets the IP ACL rules</param>
        public NetworkRuleSet(DefaultAction defaultAction, Bypass bypass = default(Bypass), IList<VirtualNetworkRule> virtualNetworkRules = default(IList<VirtualNetworkRule>), IList<IPRule> ipRules = default(IList<IPRule>))
        {
            Bypass = bypass;
            VirtualNetworkRules = virtualNetworkRules;
            IpRules = ipRules;
            DefaultAction = defaultAction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether traffic is bypassed for
        /// Logging/Metrics/AzureServices. Possible values are any combination
        /// of Logging|Metrics|AzureServices (For example, "Logging, Metrics"),
        /// or None to bypass none of those traffics. Possible values include:
        /// 'None', 'Logging', 'Metrics', 'AzureServices'
        /// </summary>
        [JsonProperty(PropertyName = "bypass")]
        public Bypass Bypass { get; set; }

        /// <summary>
        /// Gets or sets sets the virtual network rules
        /// </summary>
        [JsonProperty(PropertyName = "virtualNetworkRules")]
        public IList<VirtualNetworkRule> VirtualNetworkRules { get; set; }

        /// <summary>
        /// Gets or sets sets the IP ACL rules
        /// </summary>
        [JsonProperty(PropertyName = "ipRules")]
        public IList<IPRule> IpRules { get; set; }

        /// <summary>
        /// Gets or sets specifies the default action of allow or deny when no
        /// other rules match. Possible values include: 'Allow', 'Deny'
        /// </summary>
        [JsonProperty(PropertyName = "defaultAction")]
        public DefaultAction DefaultAction { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VirtualNetworkRules != null)
            {
                foreach (var element in VirtualNetworkRules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (IpRules != null)
            {
                foreach (var element1 in IpRules)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
