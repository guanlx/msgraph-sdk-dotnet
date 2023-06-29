using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance {
    public enum ValueTypeObject {
        [EnumMember(Value = "enum")]
        EnumObject,
        [EnumMember(Value = "string")]
        StringObject,
        [EnumMember(Value = "int")]
        Int,
        [EnumMember(Value = "bool")]
        Bool,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
