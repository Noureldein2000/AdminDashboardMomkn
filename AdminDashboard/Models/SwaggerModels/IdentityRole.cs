/* 
 * API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = AdminDashboard.SwaggerClientHelpers.SwaggerDateConverter;

namespace AdminDashboard.Models.SwaggerModels
{
    /// <summary>
    /// IdentityRole
    /// </summary>
    [DataContract]
        public partial class IdentityRole :  IEquatable<IdentityRole>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityRole" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="normalizedName">normalizedName.</param>
        /// <param name="concurrencyStamp">concurrencyStamp.</param>
        public IdentityRole(string id = default(string), string name = default(string), string normalizedName = default(string), string concurrencyStamp = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.NormalizedName = normalizedName;
            this.ConcurrencyStamp = concurrencyStamp;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NormalizedName
        /// </summary>
        [DataMember(Name="normalizedName", EmitDefaultValue=false)]
        public string NormalizedName { get; set; }

        /// <summary>
        /// Gets or Sets ConcurrencyStamp
        /// </summary>
        [DataMember(Name="concurrencyStamp", EmitDefaultValue=false)]
        public string ConcurrencyStamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityRole {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NormalizedName: ").Append(NormalizedName).Append("\n");
            sb.Append("  ConcurrencyStamp: ").Append(ConcurrencyStamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdentityRole);
        }

        /// <summary>
        /// Returns true if IdentityRole instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentityRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityRole input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NormalizedName == input.NormalizedName ||
                    (this.NormalizedName != null &&
                    this.NormalizedName.Equals(input.NormalizedName))
                ) && 
                (
                    this.ConcurrencyStamp == input.ConcurrencyStamp ||
                    (this.ConcurrencyStamp != null &&
                    this.ConcurrencyStamp.Equals(input.ConcurrencyStamp))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NormalizedName != null)
                    hashCode = hashCode * 59 + this.NormalizedName.GetHashCode();
                if (this.ConcurrencyStamp != null)
                    hashCode = hashCode * 59 + this.ConcurrencyStamp.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
