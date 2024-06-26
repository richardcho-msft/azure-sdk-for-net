// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary>
    /// Holds details about billing type and its meter guids
    /// Please note <see cref="EdgeOrderProductMeterDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="Pav2MeterDetails"/> and <see cref="PurchaseMeterDetails"/>.
    /// </summary>
    public abstract partial class EdgeOrderProductMeterDetails
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EdgeOrderProductMeterDetails"/>. </summary>
        protected EdgeOrderProductMeterDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderProductMeterDetails"/>. </summary>
        /// <param name="billingType"> Represents billing type. </param>
        /// <param name="multiplier"> Billing unit applicable for Pav2 billing. </param>
        /// <param name="chargingType"> Charging type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeOrderProductMeterDetails(BillingType billingType, double? multiplier, EdgeOrderProductChargingType? chargingType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BillingType = billingType;
            Multiplier = multiplier;
            ChargingType = chargingType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Represents billing type. </summary>
        internal BillingType BillingType { get; set; }
        /// <summary> Billing unit applicable for Pav2 billing. </summary>
        public double? Multiplier { get; }
        /// <summary> Charging type. </summary>
        public EdgeOrderProductChargingType? ChargingType { get; }
    }
}
