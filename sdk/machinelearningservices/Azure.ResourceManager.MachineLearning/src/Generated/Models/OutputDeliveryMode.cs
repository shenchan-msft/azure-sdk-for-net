// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Output data delivery mode enums. </summary>
    public readonly partial struct OutputDeliveryMode : IEquatable<OutputDeliveryMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OutputDeliveryMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OutputDeliveryMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReadWriteMountValue = "ReadWriteMount";
        private const string UploadValue = "Upload";

        /// <summary> ReadWriteMount. </summary>
        public static OutputDeliveryMode ReadWriteMount { get; } = new OutputDeliveryMode(ReadWriteMountValue);
        /// <summary> Upload. </summary>
        public static OutputDeliveryMode Upload { get; } = new OutputDeliveryMode(UploadValue);
        /// <summary> Determines if two <see cref="OutputDeliveryMode"/> values are the same. </summary>
        public static bool operator ==(OutputDeliveryMode left, OutputDeliveryMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OutputDeliveryMode"/> values are not the same. </summary>
        public static bool operator !=(OutputDeliveryMode left, OutputDeliveryMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OutputDeliveryMode"/>. </summary>
        public static implicit operator OutputDeliveryMode(string value) => new OutputDeliveryMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OutputDeliveryMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OutputDeliveryMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
