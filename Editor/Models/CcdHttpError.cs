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
    /// CcdHttpError model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.httpError")]
    public class CcdHttpError
    {
        /// <summary>
        /// Creates an instance of CcdHttpError.
        /// </summary>
        /// <param name="code">code param</param>
        /// <param name="details">details param</param>
        /// <param name="reason">reason param</param>
        [Preserve]
        public CcdHttpError(CcdErrorCodes code = default, List<string> details = default, string reason = default)
        {
            Code = code;
            Details = details;
            Reason = reason;
        }

        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CcdErrorCodes Code{ get; }
        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<string> Details{ get; }
        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason{ get; }
    
    }
}
