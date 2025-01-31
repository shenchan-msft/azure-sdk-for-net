// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration settings of the Azure Active Directory token
    /// validation flow.
    /// </summary>
    public partial class AzureActiveDirectoryValidation
    {
        /// <summary>
        /// Initializes a new instance of the AzureActiveDirectoryValidation
        /// class.
        /// </summary>
        public AzureActiveDirectoryValidation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureActiveDirectoryValidation
        /// class.
        /// </summary>
        /// <param name="jwtClaimChecks">The configuration settings of the
        /// checks that should be made while validating the JWT Claims.</param>
        /// <param name="allowedAudiences">The list of audiences that can make
        /// successful authentication/authorization requests.</param>
        /// <param name="defaultAuthorizationPolicy">The configuration settings
        /// of the default authorization policy.</param>
        public AzureActiveDirectoryValidation(JwtClaimChecks jwtClaimChecks = default(JwtClaimChecks), IList<string> allowedAudiences = default(IList<string>), DefaultAuthorizationPolicy defaultAuthorizationPolicy = default(DefaultAuthorizationPolicy))
        {
            JwtClaimChecks = jwtClaimChecks;
            AllowedAudiences = allowedAudiences;
            DefaultAuthorizationPolicy = defaultAuthorizationPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the configuration settings of the checks that should
        /// be made while validating the JWT Claims.
        /// </summary>
        [JsonProperty(PropertyName = "jwtClaimChecks")]
        public JwtClaimChecks JwtClaimChecks { get; set; }

        /// <summary>
        /// Gets or sets the list of audiences that can make successful
        /// authentication/authorization requests.
        /// </summary>
        [JsonProperty(PropertyName = "allowedAudiences")]
        public IList<string> AllowedAudiences { get; set; }

        /// <summary>
        /// Gets or sets the configuration settings of the default
        /// authorization policy.
        /// </summary>
        [JsonProperty(PropertyName = "defaultAuthorizationPolicy")]
        public DefaultAuthorizationPolicy DefaultAuthorizationPolicy { get; set; }

    }
}
