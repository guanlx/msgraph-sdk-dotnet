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
    /// The type Post.
    /// </summary>
    public partial class Post : OutlookItem
    {
    
        ///<summary>
        /// The Post constructor
        ///</summary>
        public Post()
        {
            this.ODataType = "microsoft.graph.post";
        }

        /// <summary>
        /// Gets or sets body.
        /// The contents of the post. This is a default property. This property can be null.
        /// </summary>
        [JsonPropertyName("body")]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets conversation id.
        /// Unique ID of the conversation. Read-only.
        /// </summary>
        [JsonPropertyName("conversationId")]
        public string ConversationId { get; set; }
    
        /// <summary>
        /// Gets or sets conversation thread id.
        /// Unique ID of the conversation thread. Read-only.
        /// </summary>
        [JsonPropertyName("conversationThreadId")]
        public string ConversationThreadId { get; set; }
    
        /// <summary>
        /// Gets or sets from.
        /// Used in delegate access scenarios. Indicates who posted the message on behalf of another user. This is a default property.
        /// </summary>
        [JsonPropertyName("from")]
        public Recipient From { get; set; }
    
        /// <summary>
        /// Gets or sets has attachments.
        /// Indicates whether the post has at least one attachment. This is a default property.
        /// </summary>
        [JsonPropertyName("hasAttachments")]
        public bool? HasAttachments { get; set; }
    
        /// <summary>
        /// Gets or sets new participants.
        /// Conversation participants that were added to the thread as part of this post.
        /// </summary>
        [JsonPropertyName("newParticipants")]
        public IEnumerable<Recipient> NewParticipants { get; set; }
    
        /// <summary>
        /// Gets or sets received date time.
        /// Specifies when the post was received. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("receivedDateTime")]
        public DateTimeOffset? ReceivedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets sender.
        /// Contains the address of the sender. The value of Sender is assumed to be the address of the authenticated user in the case when Sender is not specified. This is a default property.
        /// </summary>
        [JsonPropertyName("sender")]
        public Recipient Sender { get; set; }
    
        /// <summary>
        /// Gets or sets attachments.
        /// The collection of fileAttachment, itemAttachment, and referenceAttachment attachments for the post. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("attachments")]
        public IPostAttachmentsCollectionPage Attachments { get; set; }

        /// <summary>
        /// Gets or sets attachmentsNextLink.
        /// </summary>
        [JsonPropertyName("attachments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AttachmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the post. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("extensions")]
        public IPostExtensionsCollectionPage Extensions { get; set; }

        /// <summary>
        /// Gets or sets extensionsNextLink.
        /// </summary>
        [JsonPropertyName("extensions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ExtensionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets in reply to.
        /// The earlier post that this post is replying to in the conversationThread. Read-only.
        /// </summary>
        [JsonPropertyName("inReplyTo")]
        public Post InReplyTo { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the post. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties")]
        public IPostMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets multiValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MultiValueExtendedPropertiesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the post. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties")]
        public IPostSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets singleValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SingleValueExtendedPropertiesNextLink { get; set; }
    
    }
}

