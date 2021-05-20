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
    /// The type Operation.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Operation>))]
    public partial class Operation : Entity
    {
    
		///<summary>
		/// The Operation constructor
		///</summary>
        public Operation()
        {
            this.ODataType = "microsoft.graph.operation";
        }
	
        /// <summary>
        /// Gets or sets created date time.
        /// The start time of the operation.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last action date time.
        /// The time of the last action of the operation.
        /// </summary>
        [JsonPropertyName("lastActionDateTime")]
        public DateTimeOffset? LastActionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Possible values are: notStarted, running, completed, failed. Read-only.
        /// </summary>
        [JsonPropertyName("status")]
        public OperationStatus? Status { get; set; }
    
    }
}

