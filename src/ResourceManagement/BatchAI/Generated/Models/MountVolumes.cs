// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details of volumes to mount on the cluster.
    /// </summary>
    public partial class MountVolumes
    {
        /// <summary>
        /// Initializes a new instance of the MountVolumes class.
        /// </summary>
        public MountVolumes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MountVolumes class.
        /// </summary>
        /// <param name="azureFileShares">Azure File Shares.</param>
        /// <param name="azureBlobFileSystems">Azure Blob file systems.</param>
        /// <param name="fileServers">File Servers.</param>
        /// <param name="unmanagedFileSystems">Unmanaged file systems.</param>
        public MountVolumes(IList<AzureFileShareReference> azureFileShares = default(IList<AzureFileShareReference>), IList<AzureBlobFileSystemReference> azureBlobFileSystems = default(IList<AzureBlobFileSystemReference>), IList<FileServerReference> fileServers = default(IList<FileServerReference>), IList<UnmanagedFileSystemReference> unmanagedFileSystems = default(IList<UnmanagedFileSystemReference>))
        {
            AzureFileShares = azureFileShares;
            AzureBlobFileSystems = azureBlobFileSystems;
            FileServers = fileServers;
            UnmanagedFileSystems = unmanagedFileSystems;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure File Shares.
        /// </summary>
        /// <remarks>
        /// A collection of Azure File Shares that are to be mounted to the
        /// cluster nodes.
        /// </remarks>
        [JsonProperty(PropertyName = "azureFileShares")]
        public IList<AzureFileShareReference> AzureFileShares { get; set; }

        /// <summary>
        /// Gets or sets azure Blob file systems.
        /// </summary>
        /// <remarks>
        /// A collection of Azure Blob Containers that are to be mounted to the
        /// cluster nodes.
        /// </remarks>
        [JsonProperty(PropertyName = "azureBlobFileSystems")]
        public IList<AzureBlobFileSystemReference> AzureBlobFileSystems { get; set; }

        /// <summary>
        /// Gets or sets file Servers.
        /// </summary>
        /// <remarks>
        /// A collection of Batch AI File Servers that are to be mounted to the
        /// cluster nodes.
        /// </remarks>
        [JsonProperty(PropertyName = "fileServers")]
        public IList<FileServerReference> FileServers { get; set; }

        /// <summary>
        /// Gets or sets unmanaged file systems.
        /// </summary>
        /// <remarks>
        /// A collection of unmanaged file systems that are to be mounted to
        /// the cluster nodes.
        /// </remarks>
        [JsonProperty(PropertyName = "unmanagedFileSystems")]
        public IList<UnmanagedFileSystemReference> UnmanagedFileSystems { get; set; }

    }
}
