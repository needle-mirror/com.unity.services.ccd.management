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
    /// CcdMetricQuantity model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.metricQuantity")]
    public class CcdMetricQuantity
    {
        /// <summary>
        /// Creates an instance of CcdMetricQuantity.
        /// </summary>
        /// <param name="quantity">quantity param</param>
        [Preserve]
        public CcdMetricQuantity(int quantity = default)
        {
            Quantity = quantity;
        }

        /// <summary>
        /// 
        /// </summary>
        [Preserve]
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity{ get; }
    
    }
}

