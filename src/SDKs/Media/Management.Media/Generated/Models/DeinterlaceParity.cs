// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DeinterlaceParity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeinterlaceParity
    {
        /// <summary>
        /// Automatically detect the order of fields
        /// </summary>
        [EnumMember(Value = "Auto")]
        Auto,
        /// <summary>
        /// Apply top field first processing of input video.
        /// </summary>
        [EnumMember(Value = "TopFieldFirst")]
        TopFieldFirst,
        /// <summary>
        /// Apply bottom field first processing of input video.
        /// </summary>
        [EnumMember(Value = "BottomFieldFirst")]
        BottomFieldFirst
    }
    internal static class DeinterlaceParityEnumExtension
    {
        internal static string ToSerializedValue(this DeinterlaceParity? value)
        {
            return value == null ? null : ((DeinterlaceParity)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DeinterlaceParity value)
        {
            switch( value )
            {
                case DeinterlaceParity.Auto:
                    return "Auto";
                case DeinterlaceParity.TopFieldFirst:
                    return "TopFieldFirst";
                case DeinterlaceParity.BottomFieldFirst:
                    return "BottomFieldFirst";
            }
            return null;
        }

        internal static DeinterlaceParity? ParseDeinterlaceParity(this string value)
        {
            switch( value )
            {
                case "Auto":
                    return DeinterlaceParity.Auto;
                case "TopFieldFirst":
                    return DeinterlaceParity.TopFieldFirst;
                case "BottomFieldFirst":
                    return DeinterlaceParity.BottomFieldFirst;
            }
            return null;
        }
    }
}
