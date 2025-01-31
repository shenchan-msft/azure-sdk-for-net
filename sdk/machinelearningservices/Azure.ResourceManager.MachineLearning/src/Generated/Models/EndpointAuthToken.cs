// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Service Token. </summary>
    public partial class EndpointAuthToken
    {
        /// <summary> Initializes a new instance of EndpointAuthToken. </summary>
        internal EndpointAuthToken()
        {
        }

        /// <summary> Initializes a new instance of EndpointAuthToken. </summary>
        /// <param name="accessToken"> Access token for endpoint authentication. </param>
        /// <param name="expiryTimeUtc"> Access token expiry time (UTC). </param>
        /// <param name="refreshAfterTimeUtc"> Refresh access token after time (UTC). </param>
        /// <param name="tokenType"> Access token type. </param>
        internal EndpointAuthToken(string accessToken, long? expiryTimeUtc, long? refreshAfterTimeUtc, string tokenType)
        {
            AccessToken = accessToken;
            ExpiryTimeUtc = expiryTimeUtc;
            RefreshAfterTimeUtc = refreshAfterTimeUtc;
            TokenType = tokenType;
        }

        /// <summary> Access token for endpoint authentication. </summary>
        public string AccessToken { get; }
        /// <summary> Access token expiry time (UTC). </summary>
        public long? ExpiryTimeUtc { get; }
        /// <summary> Refresh access token after time (UTC). </summary>
        public long? RefreshAfterTimeUtc { get; }
        /// <summary> Access token type. </summary>
        public string TokenType { get; }
    }
}
