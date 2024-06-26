// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the regional replication status. </summary>
    public partial class RegionalReplicationStatus
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RegionalReplicationStatus"/>. </summary>
        internal RegionalReplicationStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RegionalReplicationStatus"/>. </summary>
        /// <param name="region"> The region to which the gallery image version is being replicated to. </param>
        /// <param name="state"> This is the regional replication state. </param>
        /// <param name="details"> The details of the replication status. </param>
        /// <param name="progress"> It indicates progress of the replication job. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RegionalReplicationStatus(string region, RegionalReplicationState? state, string details, int? progress, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Region = region;
            State = state;
            Details = details;
            Progress = progress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The region to which the gallery image version is being replicated to. </summary>
        public string Region { get; }
        /// <summary> This is the regional replication state. </summary>
        public RegionalReplicationState? State { get; }
        /// <summary> The details of the replication status. </summary>
        public string Details { get; }
        /// <summary> It indicates progress of the replication job. </summary>
        public int? Progress { get; }
    }
}
