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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Common error representation.
    /// </summary>
    public partial class Error
    {
        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        public Error()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        /// <param name="code">Error code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="target">Error target.</param>
        /// <param name="details">Error details.</param>
        /// <param name="innerError">Inner error message.</param>
        public Error(string code = default(string), string message = default(string), string target = default(string), IList<ErrorDetails> details = default(IList<ErrorDetails>), string innerError = default(string))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            InnerError = innerError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets error target.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets error details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ErrorDetails> Details { get; set; }

        /// <summary>
        /// Gets or sets inner error message.
        /// </summary>
        [JsonProperty(PropertyName = "innerError")]
        public string InnerError { get; set; }

    }
}
