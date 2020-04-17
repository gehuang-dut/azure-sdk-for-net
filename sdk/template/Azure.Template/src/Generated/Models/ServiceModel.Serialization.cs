// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Template.Models
{
    public partial class ServiceModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ModelProperty != null)
            {
                writer.WritePropertyName("ModelProperty");
                writer.WriteStringValue(ModelProperty);
            }
            writer.WritePropertyName("Fruit");
            writer.WriteStringValue(Fruit.ToString());
            writer.WritePropertyName("DaysOfWeek");
            writer.WriteStringValue(DaysOfWeek.ToString());
            writer.WriteEndObject();
        }

        internal static ServiceModel DeserializeServiceModel(JsonElement element)
        {
            string modelProperty = default;
            FruitType fruit = default;
            DaysOfWeek daysOfWeek = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ModelProperty"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modelProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Fruit"))
                {
                    fruit = new FruitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("DaysOfWeek"))
                {
                    daysOfWeek = new DaysOfWeek(property.Value.GetString());
                    continue;
                }
            }
            return new ServiceModel(modelProperty, fruit, daysOfWeek);
        }
    }
}