// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AppIdentity.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AppIdentity>))]
    public partial class AppIdentity
    {

        /// <summary>
        /// Gets or sets appId.
        /// Refers to the unique identifier representing Application Id in the Azure Active Directory.
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// Refers to the Application Name displayed in the Azure Portal.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets servicePrincipalId.
        /// Refers to the unique identifier indicating Service Principal Id in Azure Active Directory for the corresponding App.
        /// </summary>
        [JsonPropertyName("servicePrincipalId")]
        public string ServicePrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets servicePrincipalName.
        /// Refers to the Service Principal Name is the Application name in the tenant.
        /// </summary>
        [JsonPropertyName("servicePrincipalName")]
        public string ServicePrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
