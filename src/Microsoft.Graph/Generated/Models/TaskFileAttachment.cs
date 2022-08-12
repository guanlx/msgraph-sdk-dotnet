using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class TaskFileAttachment : AttachmentBase, IParsable {
        /// <summary>The base64-encoded contents of the file.</summary>
        public byte[] ContentBytes {
            get { return BackingStore?.Get<byte[]>("contentBytes"); }
            set { BackingStore?.Set("contentBytes", value); }
        }
        /// <summary>
        /// Instantiates a new TaskFileAttachment and sets the default values.
        /// </summary>
        public TaskFileAttachment() : base() {
            OdataType = "#microsoft.graph.taskFileAttachment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TaskFileAttachment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaskFileAttachment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contentBytes", n => { ContentBytes = n.GetByteArrayValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("contentBytes", ContentBytes);
        }
    }
}
