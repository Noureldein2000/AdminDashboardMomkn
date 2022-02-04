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
    /// AccountChannelHistoryModel
    /// </summary>
    [DataContract]
        public partial class AccountChannelHistoryModel :  IEquatable<AccountChannelHistoryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountChannelHistoryModel" /> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="channelName">channelName.</param>
        /// <param name="channelValue">channelValue.</param>
        /// <param name="status">status.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="reason">reason.</param>
        public AccountChannelHistoryModel(string accountName = default(string), string channelName = default(string), string channelValue = default(string), string status = default(string), string createdBy = default(string), string reason = default(string))
        {
            this.AccountName = accountName;
            this.ChannelName = channelName;
            this.ChannelValue = channelValue;
            this.Status = status;
            this.CreatedBy = createdBy;
            this.Reason = reason;
        }
        
        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets ChannelName
        /// </summary>
        [DataMember(Name="channelName", EmitDefaultValue=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Gets or Sets ChannelValue
        /// </summary>
        [DataMember(Name="channelValue", EmitDefaultValue=false)]
        public string ChannelValue { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountChannelHistoryModel {\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  ChannelValue: ").Append(ChannelValue).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as AccountChannelHistoryModel);
        }

        /// <summary>
        /// Returns true if AccountChannelHistoryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountChannelHistoryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountChannelHistoryModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
                ) && 
                (
                    this.ChannelValue == input.ChannelValue ||
                    (this.ChannelValue != null &&
                    this.ChannelValue.Equals(input.ChannelValue))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.ChannelName != null)
                    hashCode = hashCode * 59 + this.ChannelName.GetHashCode();
                if (this.ChannelValue != null)
                    hashCode = hashCode * 59 + this.ChannelValue.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
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
