// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class SearchServiceLimits
    {
        internal static SearchServiceLimits DeserializeSearchServiceLimits(JsonElement element)
        {
            SearchServiceLimits result = new SearchServiceLimits();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxFieldsPerIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaxFieldsPerIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxFieldNestingDepthPerIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaxFieldNestingDepthPerIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxComplexCollectionFieldsPerIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaxComplexCollectionFieldsPerIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxComplexObjectsInCollectionsPerDocument"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MaxComplexObjectsInCollectionsPerDocument = property.Value.GetInt32();
                    continue;
                }
            }
            return result;
        }
    }
}