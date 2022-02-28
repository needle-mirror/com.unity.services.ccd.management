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
    /// InternalServerError model
    /// </summary>
    [Preserve]
    [DataContract(Name = "InternalServerError")]
    public class InternalServerError
    {
        /// <summary>
        /// Creates an instance of InternalServerError.
        /// </summary>
        /// <param name="title">title param</param>
        /// <param name="status">status param</param>
        [Preserve]
        public InternalServerError(string title = default, int status = default)
        {
            Title = title;
            Status = status;
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
    
    }
}

