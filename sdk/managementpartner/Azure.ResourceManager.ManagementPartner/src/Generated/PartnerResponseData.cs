// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagementPartner.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagementPartner
{
    /// <summary>
    /// A class representing the PartnerResponse data model.
    /// this is the management partner operations response
    /// </summary>
    public partial class PartnerResponseData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="PartnerResponseData"/>. </summary>
        internal PartnerResponseData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PartnerResponseData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Type of the partner. </param>
        /// <param name="partnerId"> This is the partner id. </param>
        /// <param name="partnerName"> This is the partner name. </param>
        /// <param name="tenantId"> This is the tenant id. </param>
        /// <param name="objectId"> This is the object id. </param>
        /// <param name="version"> This is the version. </param>
        /// <param name="updatedOn"> This is the DateTime when the partner was updated. </param>
        /// <param name="createdOn"> This is the DateTime when the partner was created. </param>
        /// <param name="state"> This is the partner state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PartnerResponseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? etag, string partnerId, string partnerName, Guid? tenantId, string objectId, int? version, DateTimeOffset? updatedOn, DateTimeOffset? createdOn, ManagementPartnerState? state, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            PartnerId = partnerId;
            PartnerName = partnerName;
            TenantId = tenantId;
            ObjectId = objectId;
            Version = version;
            UpdatedOn = updatedOn;
            CreatedOn = createdOn;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of the partner. </summary>
        public int? ETag { get; }
        /// <summary> This is the partner id. </summary>
        public string PartnerId { get; }
        /// <summary> This is the partner name. </summary>
        public string PartnerName { get; }
        /// <summary> This is the tenant id. </summary>
        public Guid? TenantId { get; }
        /// <summary> This is the object id. </summary>
        public string ObjectId { get; }
        /// <summary> This is the version. </summary>
        public int? Version { get; }
        /// <summary> This is the DateTime when the partner was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> This is the DateTime when the partner was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> This is the partner state. </summary>
        public ManagementPartnerState? State { get; }
    }
}
