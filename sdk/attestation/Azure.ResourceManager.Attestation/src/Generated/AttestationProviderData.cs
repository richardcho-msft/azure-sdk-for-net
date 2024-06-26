// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Attestation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Attestation
{
    /// <summary>
    /// A class representing the AttestationProvider data model.
    /// Attestation service response message.
    /// </summary>
    public partial class AttestationProviderData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="AttestationProviderData"/>. </summary>
        /// <param name="location"> The location. </param>
        public AttestationProviderData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<AttestationPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="AttestationProviderData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="trustModel"> Trust model for the attestation provider. </param>
        /// <param name="status"> Status of attestation service. </param>
        /// <param name="attestUri"> Gets the uri of attestation service. </param>
        /// <param name="publicNetworkAccess"> Controls whether traffic from the public network is allowed to access the Attestation Provider APIs. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the attestation provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AttestationProviderData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string trustModel, AttestationServiceStatus? status, Uri attestUri, PublicNetworkAccessType? publicNetworkAccess, IReadOnlyList<AttestationPrivateEndpointConnectionData> privateEndpointConnections, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            TrustModel = trustModel;
            Status = status;
            AttestUri = attestUri;
            PublicNetworkAccess = publicNetworkAccess;
            PrivateEndpointConnections = privateEndpointConnections;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AttestationProviderData"/> for deserialization. </summary>
        internal AttestationProviderData()
        {
        }

        /// <summary> Trust model for the attestation provider. </summary>
        public string TrustModel { get; set; }
        /// <summary> Status of attestation service. </summary>
        public AttestationServiceStatus? Status { get; set; }
        /// <summary> Gets the uri of attestation service. </summary>
        public Uri AttestUri { get; set; }
        /// <summary> Controls whether traffic from the public network is allowed to access the Attestation Provider APIs. </summary>
        public PublicNetworkAccessType? PublicNetworkAccess { get; set; }
        /// <summary> List of private endpoint connections associated with the attestation provider. </summary>
        public IReadOnlyList<AttestationPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}
