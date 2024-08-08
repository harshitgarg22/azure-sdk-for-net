// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    public partial class FeaturesItem
    {
        internal static FeaturesItem DeserializeFeaturesItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FeatureTypeEnum? type = default;
            string id = default;
            FeaturesItemProperties properties = default;
            GeoJsonPoint geometry = default;
            IReadOnlyList<double> boundingBox = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new FeatureTypeEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = FeaturesItemProperties.DeserializeFeaturesItemProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("geometry"u8))
                {
                    geometry = GeoJsonPoint.DeserializeGeoJsonPoint(property.Value);
                    continue;
                }
                if (property.NameEquals("boundingBox"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    boundingBox = array;
                    continue;
                }
            }
            return new FeaturesItem(type, id, properties, geometry, boundingBox ?? new ChangeTrackingList<double>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static FeaturesItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFeaturesItem(document.RootElement);
        }
    }
}
