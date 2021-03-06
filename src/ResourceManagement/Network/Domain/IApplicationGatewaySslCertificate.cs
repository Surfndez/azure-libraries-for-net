// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Azure.Management.Network.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

    /// <summary>
    /// A client-side representation of an application gateway SSL certificate.
    /// </summary>
    public interface IApplicationGatewaySslCertificate :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasInner<Models.ApplicationGatewaySslCertificateInner>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IChildResource<Microsoft.Azure.Management.Network.Fluent.IApplicationGateway>
    {
        /// <summary>
        /// Gets the public data of the certificate.
        /// </summary>
        string PublicData { get; }

        /// <summary>
        /// Gets Secret Id of (base-64 encoded unencrypted pfx) 'Secret' or 'Certificate'
        /// object stored in KeyVault.
        /// </summary>
        /// <summary>
        /// Gets the secret id.
        /// </summary>
        string KeyVaultSecretId { get; }
    }
}