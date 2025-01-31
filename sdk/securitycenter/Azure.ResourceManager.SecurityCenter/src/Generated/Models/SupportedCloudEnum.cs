// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Relevant cloud for the custom assessment automation. </summary>
    public readonly partial struct SupportedCloudEnum : IEquatable<SupportedCloudEnum>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SupportedCloudEnum"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SupportedCloudEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AWSValue = "AWS";
        private const string GCPValue = "GCP";

        /// <summary> AWS. </summary>
        public static SupportedCloudEnum AWS { get; } = new SupportedCloudEnum(AWSValue);
        /// <summary> GCP. </summary>
        public static SupportedCloudEnum GCP { get; } = new SupportedCloudEnum(GCPValue);
        /// <summary> Determines if two <see cref="SupportedCloudEnum"/> values are the same. </summary>
        public static bool operator ==(SupportedCloudEnum left, SupportedCloudEnum right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SupportedCloudEnum"/> values are not the same. </summary>
        public static bool operator !=(SupportedCloudEnum left, SupportedCloudEnum right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SupportedCloudEnum"/>. </summary>
        public static implicit operator SupportedCloudEnum(string value) => new SupportedCloudEnum(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SupportedCloudEnum other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SupportedCloudEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
