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
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Ccd.Management.Http;



namespace Unity.Services.Ccd.Management.Models
{
    /// <summary>
    /// CcdUserAPIKey model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.userAPIKey")]
    public class CcdUserAPIKey
    {
        /// <summary>
        /// Creates an instance of CcdUserAPIKey.
        /// </summary>
        /// <param name="apikey">apikey param</param>
        [Preserve]
        public CcdUserAPIKey(string apikey)
        {
            Apikey = apikey;
        }

        /// <summary>
        /// Parameter apikey of CcdUserAPIKey
        /// </summary>
        [Preserve]
        [DataMember(Name = "apikey", IsRequired = true, EmitDefaultValue = true)]
        public string Apikey{ get; }
    
        /// <summary>
        /// Formats a CcdUserAPIKey into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Apikey != null)
            {
                serializedModel += "apikey," + Apikey;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a CcdUserAPIKey as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Apikey != null)
            {
                var apikeyStringValue = Apikey.ToString();
                dictionary.Add("apikey", apikeyStringValue);
            }
            
            return dictionary;
        }
    }
}
