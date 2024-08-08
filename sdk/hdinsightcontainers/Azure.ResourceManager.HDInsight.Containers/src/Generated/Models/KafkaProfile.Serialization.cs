// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class KafkaProfile : IUtf8JsonSerializable, IJsonModel<KafkaProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KafkaProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KafkaProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KafkaProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KafkaProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsKRaftEnabled))
            {
                writer.WritePropertyName("enableKRaft"u8);
                writer.WriteBooleanValue(IsKRaftEnabled.Value);
            }
            if (Optional.IsDefined(IsPublicEndpointsEnabled))
            {
                writer.WritePropertyName("enablePublicEndpoints"u8);
                writer.WriteBooleanValue(IsPublicEndpointsEnabled.Value);
            }
            if (Optional.IsDefined(RemoteStorageUriString))
            {
                writer.WritePropertyName("remoteStorageUri"u8);
                writer.WriteStringValue(RemoteStorageUriString);
            }
            writer.WritePropertyName("diskStorage"u8);
            writer.WriteObjectValue(DiskStorage, options);
            if (options.Format != "W" && Optional.IsDefined(ConnectivityEndpoints))
            {
                writer.WritePropertyName("connectivityEndpoints"u8);
                writer.WriteObjectValue(ConnectivityEndpoints, options);
            }
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

        KafkaProfile IJsonModel<KafkaProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KafkaProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KafkaProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKafkaProfile(document.RootElement, options);
        }

        internal static KafkaProfile DeserializeKafkaProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enableKRaft = default;
            bool? enablePublicEndpoints = default;
            string remoteStorageUri = default;
            DiskStorageProfile diskStorage = default;
            KafkaConnectivityEndpoints connectivityEndpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableKRaft"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableKRaft = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enablePublicEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePublicEndpoints = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("remoteStorageUri"u8))
                {
                    remoteStorageUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskStorage"u8))
                {
                    diskStorage = DiskStorageProfile.DeserializeDiskStorageProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("connectivityEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectivityEndpoints = KafkaConnectivityEndpoints.DeserializeKafkaConnectivityEndpoints(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KafkaProfile(
                enableKRaft,
                enablePublicEndpoints,
                remoteStorageUri,
                diskStorage,
                connectivityEndpoints,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsKRaftEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableKRaft: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsKRaftEnabled))
                {
                    builder.Append("  enableKRaft: ");
                    var boolValue = IsKRaftEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsPublicEndpointsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enablePublicEndpoints: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsPublicEndpointsEnabled))
                {
                    builder.Append("  enablePublicEndpoints: ");
                    var boolValue = IsPublicEndpointsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RemoteStorageUriString), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  remoteStorageUri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RemoteStorageUriString))
                {
                    builder.Append("  remoteStorageUri: ");
                    if (RemoteStorageUriString.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RemoteStorageUriString}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RemoteStorageUriString}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DiskStorage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  diskStorage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DiskStorage))
                {
                    builder.Append("  diskStorage: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DiskStorage, options, 2, false, "  diskStorage: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConnectivityEndpoints), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  connectivityEndpoints: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConnectivityEndpoints))
                {
                    builder.Append("  connectivityEndpoints: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ConnectivityEndpoints, options, 2, false, "  connectivityEndpoints: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<KafkaProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KafkaProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(KafkaProfile)} does not support writing '{options.Format}' format.");
            }
        }

        KafkaProfile IPersistableModel<KafkaProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KafkaProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKafkaProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KafkaProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KafkaProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
