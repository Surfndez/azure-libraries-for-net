// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of a storage account’s Blob service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BlobServicePropertiesInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the BlobServicePropertiesInner class.
        /// </summary>
        public BlobServicePropertiesInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobServicePropertiesInner class.
        /// </summary>
        /// <param name="cors">Specifies CORS rules for the Blob service. You
        /// can include up to five CorsRule elements in the request. If no
        /// CorsRule elements are included in the request body, all CORS rules
        /// will be deleted, and CORS will be disabled for the Blob
        /// service.</param>
        /// <param name="defaultServiceVersion">DefaultServiceVersion indicates
        /// the default version to use for requests to the Blob service if an
        /// incoming request’s version is not specified. Possible values
        /// include version 2008-10-27 and all more recent versions.</param>
        /// <param name="deleteRetentionPolicy">The blob service properties for
        /// soft delete.</param>
        public BlobServicePropertiesInner(string id = default(string), string name = default(string), string type = default(string), CorsRules cors = default(CorsRules), string defaultServiceVersion = default(string), DeleteRetentionPolicy deleteRetentionPolicy = default(DeleteRetentionPolicy))
            : base(id, name, type)
        {
            Cors = cors;
            DefaultServiceVersion = defaultServiceVersion;
            DeleteRetentionPolicy = deleteRetentionPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies CORS rules for the Blob service. You can
        /// include up to five CorsRule elements in the request. If no CorsRule
        /// elements are included in the request body, all CORS rules will be
        /// deleted, and CORS will be disabled for the Blob service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cors")]
        public CorsRules Cors { get; set; }

        /// <summary>
        /// Gets or sets defaultServiceVersion indicates the default version to
        /// use for requests to the Blob service if an incoming request’s
        /// version is not specified. Possible values include version
        /// 2008-10-27 and all more recent versions.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultServiceVersion")]
        public string DefaultServiceVersion { get; set; }

        /// <summary>
        /// Gets or sets the blob service properties for soft delete.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deleteRetentionPolicy")]
        public DeleteRetentionPolicy DeleteRetentionPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DeleteRetentionPolicy != null)
            {
                DeleteRetentionPolicy.Validate();
            }
        }
    }
}
