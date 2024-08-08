// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class CustomHostnameAnalysisResult : IUtf8JsonSerializable, IJsonModel<CustomHostnameAnalysisResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomHostnameAnalysisResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomHostnameAnalysisResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomHostnameAnalysisResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(IsHostnameAlreadyVerified))
            {
                writer.WritePropertyName("isHostnameAlreadyVerified"u8);
                writer.WriteBooleanValue(IsHostnameAlreadyVerified.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomDomainVerificationTest))
            {
                writer.WritePropertyName("customDomainVerificationTest"u8);
                writer.WriteStringValue(CustomDomainVerificationTest.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(CustomDomainVerificationFailureInfo))
            {
                writer.WritePropertyName("customDomainVerificationFailureInfo"u8);
                JsonSerializer.Serialize(writer, CustomDomainVerificationFailureInfo);
            }
            if (options.Format != "W" && Optional.IsDefined(HasConflictOnScaleUnit))
            {
                writer.WritePropertyName("hasConflictOnScaleUnit"u8);
                writer.WriteBooleanValue(HasConflictOnScaleUnit.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(HasConflictAcrossSubscription))
            {
                writer.WritePropertyName("hasConflictAcrossSubscription"u8);
                writer.WriteBooleanValue(HasConflictAcrossSubscription.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ConflictingAppResourceId))
            {
                writer.WritePropertyName("conflictingAppResourceId"u8);
                writer.WriteStringValue(ConflictingAppResourceId);
            }
            if (Optional.IsCollectionDefined(CNameRecords))
            {
                writer.WritePropertyName("cNameRecords"u8);
                writer.WriteStartArray();
                foreach (var item in CNameRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TxtRecords))
            {
                writer.WritePropertyName("txtRecords"u8);
                writer.WriteStartArray();
                foreach (var item in TxtRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ARecords))
            {
                writer.WritePropertyName("aRecords"u8);
                writer.WriteStartArray();
                foreach (var item in ARecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AlternateCNameRecords))
            {
                writer.WritePropertyName("alternateCNameRecords"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateCNameRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AlternateTxtRecords))
            {
                writer.WritePropertyName("alternateTxtRecords"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateTxtRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        CustomHostnameAnalysisResult IJsonModel<CustomHostnameAnalysisResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomHostnameAnalysisResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomHostnameAnalysisResult(document.RootElement, options);
        }

        internal static CustomHostnameAnalysisResult DeserializeCustomHostnameAnalysisResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            bool? isHostnameAlreadyVerified = default;
            DnsVerificationTestResult? customDomainVerificationTest = default;
            ResponseError customDomainVerificationFailureInfo = default;
            bool? hasConflictOnScaleUnit = default;
            bool? hasConflictAcrossSubscription = default;
            string conflictingAppResourceId = default;
            IList<string> cNameRecords = default;
            IList<string> txtRecords = default;
            IList<string> aRecords = default;
            IList<string> alternateCNameRecords = default;
            IList<string> alternateTxtRecords = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("isHostnameAlreadyVerified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isHostnameAlreadyVerified = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("customDomainVerificationTest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customDomainVerificationTest = property0.Value.GetString().ToDnsVerificationTestResult();
                            continue;
                        }
                        if (property0.NameEquals("customDomainVerificationFailureInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customDomainVerificationFailureInfo = JsonSerializer.Deserialize<ResponseError>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hasConflictOnScaleUnit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasConflictOnScaleUnit = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hasConflictAcrossSubscription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasConflictAcrossSubscription = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("conflictingAppResourceId"u8))
                        {
                            conflictingAppResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cNameRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            cNameRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("txtRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            txtRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("aRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            aRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("alternateCNameRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            alternateCNameRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("alternateTxtRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            alternateTxtRecords = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CustomHostnameAnalysisResult(
                id,
                name,
                type,
                systemData,
                isHostnameAlreadyVerified,
                customDomainVerificationTest,
                customDomainVerificationFailureInfo,
                hasConflictOnScaleUnit,
                hasConflictAcrossSubscription,
                conflictingAppResourceId,
                cNameRecords ?? new ChangeTrackingList<string>(),
                txtRecords ?? new ChangeTrackingList<string>(),
                aRecords ?? new ChangeTrackingList<string>(),
                alternateCNameRecords ?? new ChangeTrackingList<string>(),
                alternateTxtRecords ?? new ChangeTrackingList<string>(),
                kind,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsHostnameAlreadyVerified), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isHostnameAlreadyVerified: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsHostnameAlreadyVerified))
                {
                    builder.Append("    isHostnameAlreadyVerified: ");
                    var boolValue = IsHostnameAlreadyVerified.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomDomainVerificationTest), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    customDomainVerificationTest: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CustomDomainVerificationTest))
                {
                    builder.Append("    customDomainVerificationTest: ");
                    builder.AppendLine($"'{CustomDomainVerificationTest.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomDomainVerificationFailureInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    customDomainVerificationFailureInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CustomDomainVerificationFailureInfo))
                {
                    builder.Append("    customDomainVerificationFailureInfo: ");
                    builder.AppendLine($"'{CustomDomainVerificationFailureInfo.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HasConflictOnScaleUnit), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    hasConflictOnScaleUnit: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HasConflictOnScaleUnit))
                {
                    builder.Append("    hasConflictOnScaleUnit: ");
                    var boolValue = HasConflictOnScaleUnit.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HasConflictAcrossSubscription), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    hasConflictAcrossSubscription: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HasConflictAcrossSubscription))
                {
                    builder.Append("    hasConflictAcrossSubscription: ");
                    var boolValue = HasConflictAcrossSubscription.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConflictingAppResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    conflictingAppResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConflictingAppResourceId))
                {
                    builder.Append("    conflictingAppResourceId: ");
                    if (ConflictingAppResourceId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ConflictingAppResourceId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ConflictingAppResourceId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CNameRecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    cNameRecords: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(CNameRecords))
                {
                    if (CNameRecords.Any())
                    {
                        builder.Append("    cNameRecords: ");
                        builder.AppendLine("[");
                        foreach (var item in CNameRecords)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TxtRecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    txtRecords: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(TxtRecords))
                {
                    if (TxtRecords.Any())
                    {
                        builder.Append("    txtRecords: ");
                        builder.AppendLine("[");
                        foreach (var item in TxtRecords)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ARecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    aRecords: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ARecords))
                {
                    if (ARecords.Any())
                    {
                        builder.Append("    aRecords: ");
                        builder.AppendLine("[");
                        foreach (var item in ARecords)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlternateCNameRecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    alternateCNameRecords: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AlternateCNameRecords))
                {
                    if (AlternateCNameRecords.Any())
                    {
                        builder.Append("    alternateCNameRecords: ");
                        builder.AppendLine("[");
                        foreach (var item in AlternateCNameRecords)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlternateTxtRecords), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    alternateTxtRecords: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AlternateTxtRecords))
                {
                    if (AlternateTxtRecords.Any())
                    {
                        builder.Append("    alternateTxtRecords: ");
                        builder.AppendLine("[");
                        foreach (var item in AlternateTxtRecords)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CustomHostnameAnalysisResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CustomHostnameAnalysisResult)} does not support writing '{options.Format}' format.");
            }
        }

        CustomHostnameAnalysisResult IPersistableModel<CustomHostnameAnalysisResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomHostnameAnalysisResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomHostnameAnalysisResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomHostnameAnalysisResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
