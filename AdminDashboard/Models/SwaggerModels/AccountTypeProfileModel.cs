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
    /// AccountTypeProfileModel
    /// </summary>
    [DataContract]
        public partial class AccountTypeProfileModel :  IEquatable<AccountTypeProfileModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTypeProfileModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="accountTypeID">accountTypeID.</param>
        /// <param name="profileID">profileID.</param>
        /// <param name="profile">profile.</param>
        /// <param name="fullName">fullName.</param>
        public AccountTypeProfileModel(int? id = default(int?), int? accountTypeID = default(int?), int? profileID = default(int?), string profile = default(string), string fullName = default(string))
        {
            this.Id = id;
            this.AccountTypeID = accountTypeID;
            this.ProfileID = profileID;
            this.Profile = profile;
            this.FullName = fullName;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets AccountTypeID
        /// </summary>
        [DataMember(Name="accountTypeID", EmitDefaultValue=false)]
        public int? AccountTypeID { get; set; }

        /// <summary>
        /// Gets or Sets ProfileID
        /// </summary>
        [DataMember(Name="profileID", EmitDefaultValue=false)]
        public int? ProfileID { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public string Profile { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountTypeProfileModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountTypeID: ").Append(AccountTypeID).Append("\n");
            sb.Append("  ProfileID: ").Append(ProfileID).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
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
            return this.Equals(input as AccountTypeProfileModel);
        }

        /// <summary>
        /// Returns true if AccountTypeProfileModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountTypeProfileModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountTypeProfileModel input)
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
                    this.AccountTypeID == input.AccountTypeID ||
                    (this.AccountTypeID != null &&
                    this.AccountTypeID.Equals(input.AccountTypeID))
                ) && 
                (
                    this.ProfileID == input.ProfileID ||
                    (this.ProfileID != null &&
                    this.ProfileID.Equals(input.ProfileID))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
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
                if (this.AccountTypeID != null)
                    hashCode = hashCode * 59 + this.AccountTypeID.GetHashCode();
                if (this.ProfileID != null)
                    hashCode = hashCode * 59 + this.ProfileID.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
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
