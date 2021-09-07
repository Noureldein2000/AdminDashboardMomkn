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
    /// CreateUserModel
    /// </summary>
    [DataContract]
        public partial class CreateUserModel :  IEquatable<CreateUserModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUserModel" /> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="email">email.</param>
        /// <param name="userRole">userRole.</param>
        public CreateUserModel(string username = default(string), string password = default(string), int? accountId = default(int?), string email = default(string), Roles userRole = default(Roles))
        {
            this.Username = username;
            this.Password = password;
            this.AccountId = accountId;
            this.Email = email;
            this.UserRole = userRole;
        }
        
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets UserRole
        /// </summary>
        [DataMember(Name="userRole", EmitDefaultValue=false)]
        public Roles UserRole { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserModel {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  UserRole: ").Append(UserRole).Append("\n");
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
            return this.Equals(input as CreateUserModel);
        }

        /// <summary>
        /// Returns true if CreateUserModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateUserModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateUserModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.UserRole == input.UserRole ||
                    (this.UserRole != null &&
                    this.UserRole.Equals(input.UserRole))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.UserRole != null)
                    hashCode = hashCode * 59 + this.UserRole.GetHashCode();
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
