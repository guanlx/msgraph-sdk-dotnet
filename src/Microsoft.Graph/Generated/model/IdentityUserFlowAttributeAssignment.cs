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
    /// The type Identity User Flow Attribute Assignment.
    /// </summary>
    public partial class IdentityUserFlowAttributeAssignment : Entity
    {
    
		///<summary>
		/// The IdentityUserFlowAttributeAssignment constructor
		///</summary>
        public IdentityUserFlowAttributeAssignment()
        {
            this.ODataType = "microsoft.graph.identityUserFlowAttributeAssignment";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the identityUserFlowAttribute within a user flow.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is optional.
        /// Determines whether the identityUserFlowAttribute is optional. true means the user doesn't have to provide a value. false means the user cannot complete sign-up without providing a value.
        /// </summary>
        [JsonPropertyName("isOptional")]
        public bool? IsOptional { get; set; }
    
        /// <summary>
        /// Gets or sets requires verification.
        /// Determines whether the identityUserFlowAttribute requires verification. This is only used for verifying the user's phone number or email address.
        /// </summary>
        [JsonPropertyName("requiresVerification")]
        public bool? RequiresVerification { get; set; }
    
        /// <summary>
        /// Gets or sets user attribute values.
        /// The input options for the user flow attribute. Only applicable when the userInputType is radioSingleSelect, dropdownSingleSelect, or checkboxMultiSelect.
        /// </summary>
        [JsonPropertyName("userAttributeValues")]
        public IEnumerable<UserAttributeValuesItem> UserAttributeValues { get; set; }
    
        /// <summary>
        /// Gets or sets user input type.
        /// The input type of the user flow attribute. Possible values are: textBox, dateTimeDropdown, radioSingleSelect, dropdownSingleSelect, emailBox, checkboxMultiSelect.
        /// </summary>
        [JsonPropertyName("userInputType")]
        public IdentityUserFlowAttributeInputType? UserInputType { get; set; }
    
        /// <summary>
        /// Gets or sets user attribute.
        /// The user attribute that you want to add to your user flow.
        /// </summary>
        [JsonPropertyName("userAttribute")]
        public IdentityUserFlowAttribute UserAttribute { get; set; }
    
    }
}

