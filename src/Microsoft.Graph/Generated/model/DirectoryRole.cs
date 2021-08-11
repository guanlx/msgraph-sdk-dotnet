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
    /// The type Directory Role.
    /// </summary>
    public partial class DirectoryRole : DirectoryObject
    {
    
        ///<summary>
        /// The DirectoryRole constructor
        ///</summary>
        public DirectoryRole()
        {
            this.ODataType = "microsoft.graph.directoryRole";
        }

        /// <summary>
        /// Gets or sets description.
        /// The description for the directory role. Read-only.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the directory role. Read-only.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets role template id.
        /// The id of the directoryRoleTemplate that this role is based on. The property must be specified when activating a directory role in a tenant with a POST operation. After the directory role has been activated, the property is read only.
        /// </summary>
        [JsonPropertyName("roleTemplateId")]
        public string RoleTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// Users that are members of this directory role. HTTP Methods: GET, POST, DELETE. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("members")]
        public IDirectoryRoleMembersCollectionWithReferencesPage Members { get; set; }

        /// <summary>
        /// Gets or sets membersNextLink.
        /// </summary>
        [JsonPropertyName("members@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MembersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets scoped members.
        /// Members of this directory role that are scoped to administrative units. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("scopedMembers")]
        public IDirectoryRoleScopedMembersCollectionPage ScopedMembers { get; set; }

        /// <summary>
        /// Gets or sets scopedMembersNextLink.
        /// </summary>
        [JsonPropertyName("scopedMembers@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ScopedMembersNextLink { get; set; }
    
    }
}

