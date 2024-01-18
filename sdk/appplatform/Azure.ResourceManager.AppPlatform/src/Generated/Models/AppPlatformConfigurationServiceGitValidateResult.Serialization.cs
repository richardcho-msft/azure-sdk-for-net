// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformConfigurationServiceGitValidateResult : IUtf8JsonSerializable, IJsonModel<AppPlatformConfigurationServiceGitValidateResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformConfigurationServiceGitValidateResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformConfigurationServiceGitValidateResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceGitValidateResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceGitValidateResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsValid))
            {
                writer.WritePropertyName("isValid"u8);
                writer.WriteBooleanValue(IsValid.Value);
            }
            if (Optional.IsCollectionDefined(GitReposValidationResult))
            {
                writer.WritePropertyName("gitReposValidationResult"u8);
                writer.WriteStartArray();
                foreach (var item in GitReposValidationResult)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        AppPlatformConfigurationServiceGitValidateResult IJsonModel<AppPlatformConfigurationServiceGitValidateResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceGitValidateResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceGitValidateResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformConfigurationServiceGitValidateResult(document.RootElement, options);
        }

        internal static AppPlatformConfigurationServiceGitValidateResult DeserializeAppPlatformConfigurationServiceGitValidateResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isValid = default;
            Optional<IReadOnlyList<AppPlatformConfigurationServiceGitReposValidationMessages>> gitReposValidationResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isValid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isValid = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("gitReposValidationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformConfigurationServiceGitReposValidationMessages> array = new List<AppPlatformConfigurationServiceGitReposValidationMessages>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformConfigurationServiceGitReposValidationMessages.DeserializeAppPlatformConfigurationServiceGitReposValidationMessages(item));
                    }
                    gitReposValidationResult = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformConfigurationServiceGitValidateResult(Optional.ToNullable(isValid), Optional.ToList(gitReposValidationResult), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformConfigurationServiceGitValidateResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceGitValidateResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceGitValidateResult)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformConfigurationServiceGitValidateResult IPersistableModel<AppPlatformConfigurationServiceGitValidateResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceGitValidateResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformConfigurationServiceGitValidateResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceGitValidateResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformConfigurationServiceGitValidateResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
