// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type User Flow Language Configuration.
    /// </summary>
    public partial class UserFlowLanguageConfiguration : Entity
    {
    
		///<summary>
		/// The UserFlowLanguageConfiguration constructor
		///</summary>
        public UserFlowLanguageConfiguration()
        {
            this.ODataType = "microsoft.graph.userFlowLanguageConfiguration";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The language name to display. This property is read-only.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// Indicates whether the language is enabled within the user flow.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets default pages.
        /// Collection of pages with the default content to display in a user flow for a specified language. This collection does not allow any kind of modification.
        /// </summary>
        [JsonPropertyName("defaultPages")]
        public IUserFlowLanguageConfigurationDefaultPagesCollectionPage DefaultPages { get; set; }

        /// <summary>
        /// Gets or sets defaultPagesNextLink.
        /// </summary>
        [JsonPropertyName("defaultPages@odata.nextLink")]
        public string DefaultPagesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets overrides pages.
        /// Collection of pages with the overrides messages to display in a user flow for a specified language. This collection only allows to modify the content of the page, any other modification is not allowed (creation or deletion of pages).
        /// </summary>
        [JsonPropertyName("overridesPages")]
        public IUserFlowLanguageConfigurationOverridesPagesCollectionPage OverridesPages { get; set; }

        /// <summary>
        /// Gets or sets overridesPagesNextLink.
        /// </summary>
        [JsonPropertyName("overridesPages@odata.nextLink")]
        public string OverridesPagesNextLink { get; set; }
    
    }
}

