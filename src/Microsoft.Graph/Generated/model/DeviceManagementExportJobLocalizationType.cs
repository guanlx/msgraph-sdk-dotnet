// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum DeviceManagementExportJobLocalizationType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeviceManagementExportJobLocalizationType
    {
    
        /// <summary>
        /// Localized Values As Additional Column
        /// </summary>
        LocalizedValuesAsAdditionalColumn = 0,
	
        /// <summary>
        /// Replace Localizable Values
        /// </summary>
        ReplaceLocalizableValues = 1,
	
    }
}
