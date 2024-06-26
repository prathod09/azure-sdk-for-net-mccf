// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AgFoodPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AgFoodPlatform
{
    /// <summary>
    /// A class representing the FarmBeatsExtension data model.
    /// FarmBeats extension resource.
    /// </summary>
    public partial class FarmBeatsExtensionData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="FarmBeatsExtensionData"/>. </summary>
        public FarmBeatsExtensionData()
        {
            DetailedInformation = new ChangeTrackingList<DetailedInformation>();
        }

        /// <summary> Initializes a new instance of <see cref="FarmBeatsExtensionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="targetResourceType"> Target ResourceType of the farmBeatsExtension. </param>
        /// <param name="farmBeatsExtensionId"> FarmBeatsExtension ID. </param>
        /// <param name="farmBeatsExtensionName"> FarmBeatsExtension name. </param>
        /// <param name="farmBeatsExtensionVersion"> FarmBeatsExtension version. </param>
        /// <param name="publisherId"> Publisher ID. </param>
        /// <param name="description"> Textual description. </param>
        /// <param name="extensionCategory"> Category of the extension. e.g. weather/sensor/satellite. </param>
        /// <param name="extensionAuthLink"> FarmBeatsExtension auth link. </param>
        /// <param name="extensionApiDocsLink"> FarmBeatsExtension api docs link. </param>
        /// <param name="detailedInformation">
        /// Detailed information which shows summary of requested data.
        /// Used in descriptive get extension metadata call.
        /// Information for weather category per api included are apisSupported,
        /// customParameters, PlatformParameters and Units supported.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FarmBeatsExtensionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string targetResourceType, string farmBeatsExtensionId, string farmBeatsExtensionName, string farmBeatsExtensionVersion, string publisherId, string description, string extensionCategory, string extensionAuthLink, string extensionApiDocsLink, IReadOnlyList<DetailedInformation> detailedInformation, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            TargetResourceType = targetResourceType;
            FarmBeatsExtensionId = farmBeatsExtensionId;
            FarmBeatsExtensionName = farmBeatsExtensionName;
            FarmBeatsExtensionVersion = farmBeatsExtensionVersion;
            PublisherId = publisherId;
            Description = description;
            ExtensionCategory = extensionCategory;
            ExtensionAuthLink = extensionAuthLink;
            ExtensionApiDocsLink = extensionApiDocsLink;
            DetailedInformation = detailedInformation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Target ResourceType of the farmBeatsExtension. </summary>
        public string TargetResourceType { get; }
        /// <summary> FarmBeatsExtension ID. </summary>
        public string FarmBeatsExtensionId { get; }
        /// <summary> FarmBeatsExtension name. </summary>
        public string FarmBeatsExtensionName { get; }
        /// <summary> FarmBeatsExtension version. </summary>
        public string FarmBeatsExtensionVersion { get; }
        /// <summary> Publisher ID. </summary>
        public string PublisherId { get; }
        /// <summary> Textual description. </summary>
        public string Description { get; }
        /// <summary> Category of the extension. e.g. weather/sensor/satellite. </summary>
        public string ExtensionCategory { get; }
        /// <summary> FarmBeatsExtension auth link. </summary>
        public string ExtensionAuthLink { get; }
        /// <summary> FarmBeatsExtension api docs link. </summary>
        public string ExtensionApiDocsLink { get; }
        /// <summary>
        /// Detailed information which shows summary of requested data.
        /// Used in descriptive get extension metadata call.
        /// Information for weather category per api included are apisSupported,
        /// customParameters, PlatformParameters and Units supported.
        /// </summary>
        public IReadOnlyList<DetailedInformation> DetailedInformation { get; }
    }
}
