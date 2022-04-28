//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Ccd.Management.Http;



namespace Unity.Services.Ccd.Management.Models
{
    /// <summary>
    /// InlineResponse500 model
    /// </summary>
    [Preserve]
    [DataContract(Name = "inline_response_500")]
    public class InlineResponse500
    {
        /// <summary>
        /// Creates an instance of InlineResponse500.
        /// </summary>
        /// <param name="title">title param</param>
        /// <param name="status">status param</param>
        /// <param name="requestId">requestId param</param>
        [Preserve]
        public InlineResponse500(string title = default, int status = default, string requestId = default)
        {
            Title = title;
            Status = status;
            RequestId = requestId;
        }

        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title{ get; }
        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status{ get; }
        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId{ get; }
    
    }
}
