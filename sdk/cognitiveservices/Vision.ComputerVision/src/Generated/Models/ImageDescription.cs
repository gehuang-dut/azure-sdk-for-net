// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A collection of content tags, along with a list of captions sorted by
    /// confidence level, and image metadata.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ImageDescription
    {
        /// <summary>
        /// Initializes a new instance of the ImageDescription class.
        /// </summary>
        public ImageDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageDescription class.
        /// </summary>
        /// <param name="tags">A collection of image tags.</param>
        /// <param name="captions">A list of captions, sorted by confidence
        /// level.</param>
        /// <param name="requestId">Id of the REST API request.</param>
        public ImageDescription(IList<string> tags = default(IList<string>), IList<ImageCaption> captions = default(IList<ImageCaption>), string requestId = default(string), ImageMetadata metadata = default(ImageMetadata), string modelVersion = default(string))
        {
            Tags = tags;
            Captions = captions;
            RequestId = requestId;
            Metadata = metadata;
            ModelVersion = modelVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a collection of image tags.
        /// </summary>
        [JsonProperty(PropertyName = "description.tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets a list of captions, sorted by confidence level.
        /// </summary>
        [JsonProperty(PropertyName = "description.captions")]
        public IList<ImageCaption> Captions { get; set; }

        /// <summary>
        /// Gets or sets id of the REST API request.
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public ImageMetadata Metadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }

    }
}
