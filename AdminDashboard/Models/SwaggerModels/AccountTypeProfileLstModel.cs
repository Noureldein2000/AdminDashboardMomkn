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
    /// AccountTypeProfileLstModel
    /// </summary>
    [DataContract]
        public partial class AccountTypeProfileLstModel :  IEquatable<AccountTypeProfileLstModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTypeProfileLstModel" /> class.
        /// </summary>
        /// <param name="lstProfile">lstProfile.</param>
        /// <param name="lstAccountType">lstAccountType.</param>
        public AccountTypeProfileLstModel(List<ProfileDTO> lstProfile = default(List<ProfileDTO>), List<AccountTypeModel> lstAccountType = default(List<AccountTypeModel>))
        {
            this.LstProfile = lstProfile;
            this.LstAccountType = lstAccountType;
        }
        
        /// <summary>
        /// Gets or Sets LstProfile
        /// </summary>
        [DataMember(Name="lstProfile", EmitDefaultValue=false)]
        public List<ProfileDTO> LstProfile { get; set; }

        /// <summary>
        /// Gets or Sets LstAccountType
        /// </summary>
        [DataMember(Name="lstAccountType", EmitDefaultValue=false)]
        public List<AccountTypeModel> LstAccountType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountTypeProfileLstModel {\n");
            sb.Append("  LstProfile: ").Append(LstProfile).Append("\n");
            sb.Append("  LstAccountType: ").Append(LstAccountType).Append("\n");
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
            return this.Equals(input as AccountTypeProfileLstModel);
        }

        /// <summary>
        /// Returns true if AccountTypeProfileLstModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountTypeProfileLstModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountTypeProfileLstModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LstProfile == input.LstProfile ||
                    this.LstProfile != null &&
                    input.LstProfile != null &&
                    this.LstProfile.SequenceEqual(input.LstProfile)
                ) && 
                (
                    this.LstAccountType == input.LstAccountType ||
                    this.LstAccountType != null &&
                    input.LstAccountType != null &&
                    this.LstAccountType.SequenceEqual(input.LstAccountType)
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
                if (this.LstProfile != null)
                    hashCode = hashCode * 59 + this.LstProfile.GetHashCode();
                if (this.LstAccountType != null)
                    hashCode = hashCode * 59 + this.LstAccountType.GetHashCode();
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
