using System;
using System.Collections.Generic;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.CCD.Management.Http;



namespace Unity.Services.CCD.Management.Models
{
    /// <summary>
    /// CcdEntryUpdate model
    /// <param name="content_hash">content_hash param</param>
    /// <param name="content_size">content_size param</param>
    /// <param name="content_type">content_type param</param>
    /// <param name="labels">labels param</param>
    /// <param name="metadata">metadata param</param>
    /// </summary>

    [Preserve]
    [DataContract(Name = "ccd.entryUpdate")]
    public class CcdEntryUpdate
    {
        /// <summary>
        /// Creates an instance of CcdEntryUpdate.
        /// </summary>
        /// <param name="contentHash">content_hash param</param>
        /// <param name="contentSize">content_size param</param>
        /// <param name="contentType">content_type param</param>
        /// <param name="labels">labels param</param>
        /// <param name="metadata">metadata param</param>
        [Preserve]
        public CcdEntryUpdate(string contentHash = default, int contentSize = default, string contentType = default, List<string> labels = default, object metadata = default)
        {
            ContentHash = contentHash;
            ContentSize = contentSize;
            ContentType = contentType;
            Labels = labels;
            Metadata = metadata != null ? new JsonObject(metadata) : null;
        }

        /// <summary>
        /// Content hash
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_hash", EmitDefaultValue = false)]
        public string ContentHash { get; }

        /// <summary>
        /// Content size
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_size", EmitDefaultValue = false)]
        public int ContentSize { get; }

        /// <summary>
        /// Content type
        /// </summary>
        [Preserve]
        [DataMember(Name = "content_type", EmitDefaultValue = false)]
        public string ContentType { get; }

        /// <summary>
        /// Labels
        /// </summary>
        [Preserve]
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<string> Labels { get; }

        /// <summary>
        /// Metadata
        /// </summary>
        [Preserve]
        [JsonConverter(typeof(JsonObjectConverter))]
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public JsonObject Metadata { get; }

    }
}

