// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using System.Linq;

    /// <summary>
    /// Describes the parameter of customer managed disk encryption set
    /// resource id that can be specified for disk. &lt;br&gt;&lt;br&gt; NOTE:
    /// The disk encryption set resource id can only be specified for managed
    /// disk. Please refer https://aka.ms/mdssewithcmkoverview for more
    /// details.
    /// </summary>
    public partial class DiskEncryptionSetParametersInner : Management.ResourceManager.Fluent.SubResource
    {
        /// <summary>
        /// Initializes a new instance of the DiskEncryptionSetParametersInner
        /// class.
        /// </summary>
        public DiskEncryptionSetParametersInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskEncryptionSetParametersInner
        /// class.
        /// </summary>
        public DiskEncryptionSetParametersInner(string id = default(string))
            : base(id)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
