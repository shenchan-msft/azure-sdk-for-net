// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The CheckinManifestParams. </summary>
    public partial class CheckinManifestParams
    {
        /// <summary> Initializes a new instance of CheckinManifestParams. </summary>
        /// <param name="environment"> The environment supplied to the checkin manifest operation. </param>
        /// <param name="baselineArmManifestLocation"> The baseline ARM manifest location supplied to the checkin manifest operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="environment"/> or <paramref name="baselineArmManifestLocation"/> is null. </exception>
        public CheckinManifestParams(string environment, string baselineArmManifestLocation)
        {
            if (environment == null)
            {
                throw new ArgumentNullException(nameof(environment));
            }
            if (baselineArmManifestLocation == null)
            {
                throw new ArgumentNullException(nameof(baselineArmManifestLocation));
            }

            Environment = environment;
            BaselineArmManifestLocation = baselineArmManifestLocation;
        }

        /// <summary> The environment supplied to the checkin manifest operation. </summary>
        public string Environment { get; }
        /// <summary> The baseline ARM manifest location supplied to the checkin manifest operation. </summary>
        public string BaselineArmManifestLocation { get; }
    }
}
