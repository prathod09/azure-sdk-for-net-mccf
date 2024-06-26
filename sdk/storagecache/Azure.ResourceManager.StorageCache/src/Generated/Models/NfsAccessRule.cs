// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Rule to place restrictions on portions of the cache namespace being presented to clients. </summary>
    public partial class NfsAccessRule
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

        /// <summary> Initializes a new instance of <see cref="NfsAccessRule"/>. </summary>
        /// <param name="scope"> Scope for this rule. The scope and filter determine which clients match the rule. </param>
        /// <param name="access"> Access allowed by this rule. </param>
        public NfsAccessRule(NfsAccessRuleScope scope, NfsAccessRuleAccess access)
        {
            Scope = scope;
            Access = access;
        }

        /// <summary> Initializes a new instance of <see cref="NfsAccessRule"/>. </summary>
        /// <param name="scope"> Scope for this rule. The scope and filter determine which clients match the rule. </param>
        /// <param name="filter"> Filter applied to the scope for this rule. The filter's format depends on its scope. 'default' scope matches all clients and has no filter value. 'network' scope takes a filter in CIDR format (for example, 10.99.1.0/24). 'host' takes an IP address or fully qualified domain name as filter. If a client does not match any filter rule and there is no default rule, access is denied. </param>
        /// <param name="access"> Access allowed by this rule. </param>
        /// <param name="allowSuid"> Allow SUID semantics. </param>
        /// <param name="allowSubmountAccess"> For the default policy, allow access to subdirectories under the root export. If this is set to no, clients can only mount the path '/'. If set to yes, clients can mount a deeper path, like '/a/b'. </param>
        /// <param name="enableRootSquash"> Map root accesses to anonymousUID and anonymousGID. </param>
        /// <param name="anonymousUID"> UID value that replaces 0 when rootSquash is true. 65534 will be used if not provided. </param>
        /// <param name="anonymousGID"> GID value that replaces 0 when rootSquash is true. This will use the value of anonymousUID if not provided. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NfsAccessRule(NfsAccessRuleScope scope, string filter, NfsAccessRuleAccess access, bool? allowSuid, bool? allowSubmountAccess, bool? enableRootSquash, string anonymousUID, string anonymousGID, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Scope = scope;
            Filter = filter;
            Access = access;
            AllowSuid = allowSuid;
            AllowSubmountAccess = allowSubmountAccess;
            EnableRootSquash = enableRootSquash;
            AnonymousUID = anonymousUID;
            AnonymousGID = anonymousGID;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NfsAccessRule"/> for deserialization. </summary>
        internal NfsAccessRule()
        {
        }

        /// <summary> Scope for this rule. The scope and filter determine which clients match the rule. </summary>
        public NfsAccessRuleScope Scope { get; set; }
        /// <summary> Filter applied to the scope for this rule. The filter's format depends on its scope. 'default' scope matches all clients and has no filter value. 'network' scope takes a filter in CIDR format (for example, 10.99.1.0/24). 'host' takes an IP address or fully qualified domain name as filter. If a client does not match any filter rule and there is no default rule, access is denied. </summary>
        public string Filter { get; set; }
        /// <summary> Access allowed by this rule. </summary>
        public NfsAccessRuleAccess Access { get; set; }
        /// <summary> Allow SUID semantics. </summary>
        public bool? AllowSuid { get; set; }
        /// <summary> For the default policy, allow access to subdirectories under the root export. If this is set to no, clients can only mount the path '/'. If set to yes, clients can mount a deeper path, like '/a/b'. </summary>
        public bool? AllowSubmountAccess { get; set; }
        /// <summary> Map root accesses to anonymousUID and anonymousGID. </summary>
        public bool? EnableRootSquash { get; set; }
        /// <summary> UID value that replaces 0 when rootSquash is true. 65534 will be used if not provided. </summary>
        public string AnonymousUID { get; set; }
        /// <summary> GID value that replaces 0 when rootSquash is true. This will use the value of anonymousUID if not provided. </summary>
        public string AnonymousGID { get; set; }
    }
}
