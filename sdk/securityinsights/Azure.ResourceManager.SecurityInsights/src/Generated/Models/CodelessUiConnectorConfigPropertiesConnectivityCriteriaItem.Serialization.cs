// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class CodelessUiConnectorConfigPropertiesConnectivityCriteriaItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectivityType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(ConnectivityType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static CodelessUiConnectorConfigPropertiesConnectivityCriteriaItem DeserializeCodelessUiConnectorConfigPropertiesConnectivityCriteriaItem(JsonElement element)
        {
            Optional<ConnectivityType> type = default;
            Optional<IList<string>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ConnectivityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    value = array;
                    continue;
                }
            }
            return new CodelessUiConnectorConfigPropertiesConnectivityCriteriaItem(Optional.ToNullable(type), Optional.ToList(value));
        }
    }
}
