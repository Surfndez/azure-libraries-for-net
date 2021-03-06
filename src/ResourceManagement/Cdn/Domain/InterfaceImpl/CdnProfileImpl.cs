// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Cdn.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.Definition.Blank.PremiumEndpoint;
    using Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.Definition.Blank.StandardEndpoint;
    using Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.Definition;
    using Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.UpdateDefinition.Blank.PremiumEndpoint;
    using Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.UpdateDefinition.Blank.StandardEndpoint;
    using Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.UpdateDefinition;
    using Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.UpdatePremiumEndpoint;
    using Microsoft.Azure.Management.Cdn.Fluent.CdnEndpoint.UpdateStandardEndpoint;
    using Microsoft.Azure.Management.Cdn.Fluent.CdnProfile.Definition;
    using Microsoft.Azure.Management.Cdn.Fluent.CdnProfile.Update;
    using Microsoft.Azure.Management.Cdn.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;

    internal partial class CdnProfileImpl
    {
        /// <summary>
        /// Starts the definition of a new endpoint to be attached to the CDN profile.
        /// </summary>
        /// <return>The first stage of a new CDN endpoint definition.</return>
        CdnEndpoint.Definition.Blank.StandardEndpoint.IStandardEndpoint<CdnProfile.Definition.IWithStandardCreate> CdnProfile.Definition.IWithStandardCreateBeta.DefineNewEndpoint()
        {
            return this.DefineNewEndpoint();
        }

        /// <summary>
        /// Starts the definition of a new endpoint to be attached to the CDN profile.
        /// </summary>
        /// <param name="name">A new endpoint name.</param>
        /// <return>The first stage of a new CDN endpoint definition.</return>
        CdnEndpoint.Definition.Blank.StandardEndpoint.IStandardEndpoint<CdnProfile.Definition.IWithStandardCreate> CdnProfile.Definition.IWithStandardCreate.DefineNewEndpoint(string name)
        {
            return this.DefineNewEndpoint(name);
        }

        /// <summary>
        /// Starts the definition of a new endpoint to be attached to the CDN profile.
        /// </summary>
        /// <param name="name">The name for the endpoint.</param>
        /// <param name="endpointOriginHostname">An endpoint origin hostname.</param>
        /// <return>The first stage of a new CDN endpoint definition.</return>
        CdnEndpoint.Definition.IWithStandardAttach<CdnProfile.Definition.IWithStandardCreate> CdnProfile.Definition.IWithStandardCreateBeta.DefineNewEndpoint(string name, string endpointOriginHostname)
        {
            return this.DefineNewEndpoint(name, endpointOriginHostname);
        }

        /// <summary>
        /// Adds new endpoint to the CDN profile.
        /// </summary>
        /// <param name="endpointOriginHostname">An endpoint origin hostname.</param>
        /// <return>The next stage of CDN profile definition.</return>
        CdnProfile.Definition.IWithStandardCreate CdnProfile.Definition.IWithStandardCreate.WithNewEndpoint(string endpointOriginHostname)
        {
            return this.WithNewEndpoint(endpointOriginHostname);
        }

        /// <summary>
        /// Starts the definition of a new endpoint to be attached to the CDN profile.
        /// </summary>
        /// <return>The first stage of a new CDN endpoint definition.</return>
        CdnEndpoint.Definition.Blank.PremiumEndpoint.IPremiumEndpoint<CdnProfile.Definition.IWithPremiumVerizonCreate> CdnProfile.Definition.IWithPremiumVerizonCreateBeta.DefineNewPremiumEndpoint()
        {
            return this.DefineNewPremiumEndpoint();
        }

        /// <summary>
        /// Starts the definition of a new endpoint to be attached to the CDN profile.
        /// </summary>
        /// <param name="name">A name for the endpoint.</param>
        /// <return>The first stage of a new CDN endpoint definition.</return>
        CdnEndpoint.Definition.Blank.PremiumEndpoint.IPremiumEndpoint<CdnProfile.Definition.IWithPremiumVerizonCreate> CdnProfile.Definition.IWithPremiumVerizonCreate.DefineNewPremiumEndpoint(string name)
        {
            return this.DefineNewPremiumEndpoint(name);
        }

        /// <summary>
        /// Starts the definition of a new endpoint to be attached to the CDN profile.
        /// </summary>
        /// <param name="name">The name for the endpoint.</param>
        /// <param name="endpointOriginHostname">The endpoint origin hostname.</param>
        /// <return>The stage representing configuration for the endpoint.</return>
        CdnEndpoint.Definition.IWithPremiumAttach<CdnProfile.Definition.IWithPremiumVerizonCreate> CdnProfile.Definition.IWithPremiumVerizonCreateBeta.DefineNewPremiumEndpoint(string name, string endpointOriginHostname)
        {
            return this.DefineNewPremiumEndpoint(name, endpointOriginHostname);
        }

        /// <summary>
        /// Adds a new endpoint to current CDN profile.
        /// </summary>
        /// <param name="endpointOriginHostname">An endpoint origin hostname.</param>
        /// <return>The next stage of the definition.</return>
        CdnProfile.Definition.IWithPremiumVerizonCreate CdnProfile.Definition.IWithPremiumVerizonCreate.WithNewPremiumEndpoint(string endpointOriginHostname)
        {
            return this.WithNewPremiumEndpoint(endpointOriginHostname);
        }

        /// <summary>
        /// Starts the definition of a new endpoint to be attached to the CDN profile.
        /// </summary>
        /// <return>The first stage of an endpoint definition.</return>
        CdnEndpoint.UpdateDefinition.Blank.StandardEndpoint.IStandardEndpoint<CdnProfile.Update.IUpdate> CdnProfile.Update.IWithEndpointBeta.DefineNewEndpoint()
        {
            return this.DefineNewEndpoint();
        }

        /// <summary>
        /// Starts the definition of a new endpoint to be attached to the CDN profile.
        /// </summary>
        /// <param name="name">The name for the endpoint.</param>
        /// <return>The first stage of an endpoint definition.</return>
        CdnEndpoint.UpdateDefinition.Blank.StandardEndpoint.IStandardEndpoint<CdnProfile.Update.IUpdate> CdnProfile.Update.IWithEndpoint.DefineNewEndpoint(string name)
        {
            return this.DefineNewEndpoint(name);
        }

        /// <summary>
        /// Specifies definition of an endpoint to be attached to the CDN profile.
        /// </summary>
        /// <param name="name">The name for the endpoint.</param>
        /// <param name="endpointOriginHostname">The endpoint origin hostname.</param>
        /// <return>The first stage of an endpoint definition.</return>
        CdnEndpoint.UpdateDefinition.IWithStandardAttach<CdnProfile.Update.IUpdate> CdnProfile.Update.IWithEndpointBeta.DefineNewEndpoint(string name, string endpointOriginHostname)
        {
            return this.DefineNewEndpoint(name, endpointOriginHostname);
        }

        /// <summary>
        /// Begins the description of an update of an existing endpoint in current profile.
        /// </summary>
        /// <param name="name">The name of an existing endpoint.</param>
        /// <return>The first stage of the update of the endpoint.</return>
        CdnEndpoint.UpdateStandardEndpoint.IUpdateStandardEndpoint CdnProfile.Update.IWithEndpoint.UpdateEndpoint(string name)
        {
            return this.UpdateEndpoint(name);
        }

        /// <summary>
        /// Adds a new endpoint.
        /// </summary>
        /// <param name="endpointOriginHostname">An endpoint origin hostname.</param>
        /// <return>The next stage of the update.</return>
        CdnProfile.Update.IUpdate CdnProfile.Update.IWithEndpoint.WithNewEndpoint(string endpointOriginHostname)
        {
            return this.WithNewEndpoint(endpointOriginHostname);
        }

        /// <summary>
        /// Starts the definition of a new endpoint to be attached to this Premium Verizon CDN profile.
        /// </summary>
        /// <return>The first stage of an endpoint definition.</return>
        CdnEndpoint.UpdateDefinition.Blank.PremiumEndpoint.IPremiumEndpoint<CdnProfile.Update.IUpdate> CdnProfile.Update.IWithEndpointBeta.DefineNewPremiumEndpoint()
        {
            return this.DefineNewPremiumEndpoint();
        }

        /// <summary>
        /// Starts the definition of a new endpoint to be attached to this Premium Verizon CDN profile.
        /// </summary>
        /// <param name="name">A name for the new endpoint.</param>
        /// <return>The first stage of an endpoint definition.</return>
        CdnEndpoint.UpdateDefinition.Blank.PremiumEndpoint.IPremiumEndpoint<CdnProfile.Update.IUpdate> CdnProfile.Update.IWithEndpoint.DefineNewPremiumEndpoint(string name)
        {
            return this.DefineNewPremiumEndpoint(name);
        }

        /// <summary>
        /// Starts the definition of a new endpoint to be attached to this Premium Verizon CDN profile.
        /// </summary>
        /// <param name="name">A name for the endpoint.</param>
        /// <param name="endpointOriginHostname">The endpoint origin hostname.</param>
        /// <return>The first stage of an endpoint definition.</return>
        CdnEndpoint.UpdateDefinition.IWithPremiumAttach<CdnProfile.Update.IUpdate> CdnProfile.Update.IWithEndpointBeta.DefineNewPremiumEndpoint(string name, string endpointOriginHostname)
        {
            return this.DefineNewPremiumEndpoint(name, endpointOriginHostname);
        }

        /// <summary>
        /// Begins the description of an update of an existing endpoint in current Premium Verizon profile.
        /// </summary>
        /// <param name="name">The name of the endpoint.</param>
        /// <return>The first stage of the update of the endpoint.</return>
        CdnEndpoint.UpdatePremiumEndpoint.IUpdatePremiumEndpoint CdnProfile.Update.IWithEndpoint.UpdatePremiumEndpoint(string name)
        {
            return this.UpdatePremiumEndpoint(name);
        }

        /// <summary>
        /// Removes an endpoint from the profile.
        /// </summary>
        /// <param name="name">The name of an existing endpoint.</param>
        /// <return>The next stage of the CDN profile update.</return>
        CdnProfile.Update.IUpdate CdnProfile.Update.IWithEndpoint.WithoutEndpoint(string name)
        {
            return this.WithoutEndpoint(name);
        }

        /// <summary>
        /// Adds new endpoint to current Premium Verizon CDN profile.
        /// </summary>
        /// <param name="endpointOriginHostname">The endpoint origin hostname.</param>
        /// <return>The next stage of the update.</return>
        CdnProfile.Update.IUpdate CdnProfile.Update.IWithEndpoint.WithNewPremiumEndpoint(string endpointOriginHostname)
        {
            return this.WithNewPremiumEndpoint(endpointOriginHostname);
        }

        /// <summary>
        /// Gets the name of the region the resource is in.
        /// </summary>
        string Microsoft.Azure.Management.ResourceManager.Fluent.Core.IResource.RegionName
        {
            get
            {
                return this.RegionName();
            }
        }

        /// <summary>
        /// Starts a stopped CDN endpoint asynchronously.
        /// </summary>
        /// <param name="endpointName">A name of an endpoint under the profile.</param>
        /// <return>A representation of the deferred computation of this call.</return>
        async Task Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.StartEndpointAsync(string endpointName, CancellationToken cancellationToken)
        {

            await this.StartEndpointAsync(endpointName, cancellationToken);
        }

        /// <summary>
        /// Forcibly purges CDN endpoint content in the CDN profile asynchronously.
        /// </summary>
        /// <param name="endpointName">A name of the endpoint under the profile.</param>
        /// <param name="contentPaths">The paths to the content to be purged, which can be file paths or directory wild cards.</param>
        /// <return>A representation of the deferred computation of this call.</return>
        async Task Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.PurgeEndpointContentAsync(string endpointName, ISet<string> contentPaths, CancellationToken cancellationToken)
        {

            await this.PurgeEndpointContentAsync(endpointName, contentPaths, cancellationToken);
        }

        /// <summary>
        /// Stops a running CDN endpoint.
        /// </summary>
        /// <param name="endpointName">A name of an endpoint under the profile.</param>
        void Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.StopEndpoint(string endpointName)
        {

            this.StopEndpoint(endpointName);
        }

        /// <summary>
        /// Validates a custom domain mapping to ensure it maps to the correct CNAME in DNS in current profile.
        /// </summary>
        /// <param name="endpointName">A name of the endpoint under the profile.</param>
        /// <param name="hostName">The host name of the custom domain, which must be a domain name.</param>
        /// <return>CustomDomainValidationResult object if successful.</return>
        Microsoft.Azure.Management.Cdn.Fluent.CustomDomainValidationResult Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.ValidateEndpointCustomDomain(string endpointName, string hostName)
        {
            return this.ValidateEndpointCustomDomain(endpointName, hostName);
        }

        /// <return>Quotas and actual usages of endpoints under the current CDN profile.</return>
        System.Collections.Generic.IEnumerable<Models.ResourceUsage> Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.ListResourceUsage()
        {
            return this.ListResourceUsage();
        }

        /// <summary>
        /// Stops a running CDN endpoint asynchronously.
        /// </summary>
        /// <param name="endpointName">A name of an endpoint under the profile.</param>
        /// <return>A representation of the deferred computation of this call.</return>
        async Task Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.StopEndpointAsync(string endpointName, CancellationToken cancellationToken)
        {

            await this.StopEndpointAsync(endpointName, cancellationToken);
        }

        /// <summary>
        /// Generates a dynamic SSO URI used to sign in to the CDN supplemental portal used for advanced management tasks.
        /// </summary>
        /// <return>URI used to login to the third party web portal.</return>
        string Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.GenerateSsoUri()
        {
            return this.GenerateSsoUri();
        }

        /// <summary>
        /// Gets true if this CDN profile's SKU is of Premium Verizon, else false.
        /// </summary>
        bool Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.IsPremiumVerizon
        {
            get
            {
                return this.IsPremiumVerizon();
            }
        }

        /// <summary>
        /// Starts a stopped CDN endpoint.
        /// </summary>
        /// <param name="endpointName">A name of an endpoint under the profile.</param>
        void Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.StartEndpoint(string endpointName)
        {

            this.StartEndpoint(endpointName);
        }

        /// <summary>
        /// Checks the availability of an endpoint name without creating the CDN endpoint.
        /// </summary>
        /// <param name="name">The endpoint resource name to validate.</param>
        /// <return>The result if successful.</return>
        Microsoft.Azure.Management.Cdn.Fluent.CheckNameAvailabilityResult Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.CheckEndpointNameAvailability(string name)
        {
            return this.CheckEndpointNameAvailability(name);
        }

        /// <summary>
        /// Forcibly purges CDN endpoint content in the CDN profile.
        /// </summary>
        /// <param name="endpointName">A name of the endpoint under the profile.</param>
        /// <param name="contentPaths">The paths to the content to be purged, which can be file paths or directory wild cards.</param>
        void Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.PurgeEndpointContent(string endpointName, ISet<string> contentPaths)
        {

            this.PurgeEndpointContent(endpointName, contentPaths);
        }

        /// <summary>
        /// Gets CDN profile state.
        /// </summary>
        ProfileResourceState Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.ResourceState
        {
            get
            {
                return this.ResourceState();
            }
        }

        /// <summary>
        /// Gets the SKU of the CDN profile.
        /// </summary>
        Models.Sku Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.Sku
        {
            get
            {
                return this.Sku();
            }
        }

        /// <summary>
        /// Gets endpoints in the CDN manager profile, indexed by name.
        /// </summary>
        System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Azure.Management.Cdn.Fluent.ICdnEndpoint> Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.Endpoints
        {
            get
            {
                return this.Endpoints();
            }
        }

        /// <summary>
        /// Checks the availability of an endpoint name without creating the CDN endpoint asynchronously.
        /// </summary>
        /// <param name="name">The endpoint resource name to validate.</param>
        /// <return>A representation of the deferred computation of this call.</return>
        async Task<Microsoft.Azure.Management.Cdn.Fluent.CheckNameAvailabilityResult> Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.CheckEndpointNameAvailabilityAsync(string name, CancellationToken cancellationToken)
        {
            return await this.CheckEndpointNameAvailabilityAsync(name, cancellationToken);
        }

        /// <summary>
        /// Asynchronously generates a dynamic SSO URI used to sign into the CDN supplemental portal used for advanced management tasks.
        /// </summary>
        /// <return>Observable to URI used to login to third party web portal.</return>
        async Task<string> Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.GenerateSsoUriAsync(CancellationToken cancellationToken)
        {
            return await this.GenerateSsoUriAsync(cancellationToken);
        }

        /// <summary>
        /// Forcibly pre-loads CDN endpoint content in the CDN profile.
        /// Note, this is Available for Verizon Profiles only.
        /// </summary>
        /// <param name="endpointName">A name of the endpoint under the profile.</param>
        /// <param name="contentPaths">The paths to the content to be purged, which can be file paths or directory wild cards.</param>
        void Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.LoadEndpointContent(string endpointName, ISet<string> contentPaths)
        {

            this.LoadEndpointContent(endpointName, contentPaths);
        }

        /// <summary>
        /// Forcibly pre-loads CDN endpoint content in the CDN profile asynchronously.
        /// Note, this is Available for Verizon Profiles only.
        /// </summary>
        /// <param name="endpointName">A name of the endpoint under the profile.</param>
        /// <param name="contentPaths">The paths to the content to be purged, which can be file paths or directory wild cards.</param>
        /// <return>A representation of the deferred computation of this call.</return>
        async Task Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.LoadEndpointContentAsync(string endpointName, ISet<string> contentPaths, CancellationToken cancellationToken)
        {

            await this.LoadEndpointContentAsync(endpointName, contentPaths, cancellationToken);
        }

        /// <summary>
        /// Validates a custom domain mapping to ensure it maps to the correct CNAME in DNS in current profile asynchronously.
        /// </summary>
        /// <param name="endpointName">A name of the endpoint under the profile.</param>
        /// <param name="hostName">The host name of the custom domain, which must be a domain name.</param>
        /// <return>The Observable to CustomDomainValidationResult object if successful.</return>
        async Task<Microsoft.Azure.Management.Cdn.Fluent.CustomDomainValidationResult> Microsoft.Azure.Management.Cdn.Fluent.ICdnProfile.ValidateEndpointCustomDomainAsync(string endpointName, string hostName, CancellationToken cancellationToken)
        {
            return await this.ValidateEndpointCustomDomainAsync(endpointName, hostName, cancellationToken);
        }

        /// <summary>
        /// Selects the Standard Akamai SKU.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        CdnProfile.Definition.IWithStandardCreate CdnProfile.Definition.IWithSku.WithStandardAkamaiSku()
        {
            return this.WithStandardAkamaiSku();
        }

        /// <summary>
        /// Selects the Premium Verizon SKU.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        CdnProfile.Definition.IWithPremiumVerizonCreate CdnProfile.Definition.IWithSku.WithPremiumVerizonSku()
        {
            return this.WithPremiumVerizonSku();
        }

        /// <summary>
        /// Selects the Standard Verizon SKU.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        CdnProfile.Definition.IWithStandardCreate CdnProfile.Definition.IWithSku.WithStandardVerizonSku()
        {
            return this.WithStandardVerizonSku();
        }

        /// <summary>
        /// Selects the Standard Microsoft SKU.
        /// </summary>
        /// <return>The next stage of the definition.</return>
        CdnProfile.Definition.IWithStandardCreate CdnProfile.Definition.IWithSku.WithStandardMicrosoftSku()
        {
            return this.WithStandardMicrosoftSku();
        }
    }
}