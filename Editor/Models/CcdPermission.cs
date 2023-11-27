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
    /// CcdPermission model
    /// </summary>
    [Preserve]
    [DataContract(Name = "ccd.permission")]
    public class CcdPermission
    {
        /// <summary>
        /// Creates an instance of CcdPermission.
        /// </summary>
        /// <param name="action">action param</param>
        /// <param name="permission">permission param</param>
        /// <param name="resource">resource param</param>
        /// <param name="role">role param</param>
        [Preserve]
        public CcdPermission(string action = default, string permission = default, string resource = default, string role = default)
        {
            Action = action;
            Permission = permission;
            Resource = resource;
            Role = role;
        }

        /// <summary>
        /// Parameter action of CcdPermission
        /// </summary>
        [Preserve]
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action{ get; }
        
        /// <summary>
        /// Parameter permission of CcdPermission
        /// </summary>
        [Preserve]
        [DataMember(Name = "permission", EmitDefaultValue = false)]
        public string Permission{ get; }
        
        /// <summary>
        /// Parameter resource of CcdPermission
        /// </summary>
        [Preserve]
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public string Resource{ get; }
        
        /// <summary>
        /// Parameter role of CcdPermission
        /// </summary>
        [Preserve]
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role{ get; }
    
        /// <summary>
        /// Formats a CcdPermission into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Action != null)
            {
                serializedModel += "action," + Action + ",";
            }
            if (Permission != null)
            {
                serializedModel += "permission," + Permission + ",";
            }
            if (Resource != null)
            {
                serializedModel += "resource," + Resource + ",";
            }
            if (Role != null)
            {
                serializedModel += "role," + Role;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a CcdPermission as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Action != null)
            {
                var actionStringValue = Action.ToString();
                dictionary.Add("action", actionStringValue);
            }
            
            if (Permission != null)
            {
                var permissionStringValue = Permission.ToString();
                dictionary.Add("permission", permissionStringValue);
            }
            
            if (Resource != null)
            {
                var resourceStringValue = Resource.ToString();
                dictionary.Add("resource", resourceStringValue);
            }
            
            if (Role != null)
            {
                var roleStringValue = Role.ToString();
                dictionary.Add("role", roleStringValue);
            }
            
            return dictionary;
        }
    }
}
