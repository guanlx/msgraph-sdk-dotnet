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
    /// The type Threat Assessment Result.
    /// </summary>
    public partial class ThreatAssessmentResult : Entity
    {
    
		///<summary>
		/// The ThreatAssessmentResult constructor
		///</summary>
        public ThreatAssessmentResult()
        {
            this.ODataType = "microsoft.graph.threatAssessmentResult";
        }
	
        /// <summary>
        /// Gets or sets created date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets message.
        /// The result message for each threat assessment.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    
        /// <summary>
        /// Gets or sets result type.
        /// The threat assessment result type. Possible values are: checkPolicy (only for mail assessment), rescan.
        /// </summary>
        [JsonPropertyName("resultType")]
        public ThreatAssessmentResultType? ResultType { get; set; }
    
    }
}

