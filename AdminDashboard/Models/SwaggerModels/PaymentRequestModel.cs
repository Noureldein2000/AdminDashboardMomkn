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
    /// PaymentRequestModel
    /// </summary>
    [DataContract]
        public partial class PaymentRequestModel :  IEquatable<PaymentRequestModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequestModel" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="version">version.</param>
        /// <param name="serviceListVersion">serviceListVersion.</param>
        /// <param name="billingAccount">billingAccount.</param>
        /// <param name="brn">brn.</param>
        /// <param name="accountId">accountId.</param>
        /// <param name="accountProfileId">accountProfileId.</param>
        public PaymentRequestModel(double? amount = default(double?), string version = default(string), string serviceListVersion = default(string), string billingAccount = default(string), int? brn = default(int?), int? accountId = default(int?), int? accountProfileId = default(int?))
        {
            this.Amount = amount;
            this.Version = version;
            this.ServiceListVersion = serviceListVersion;
            this.BillingAccount = billingAccount;
            this.Brn = brn;
            this.AccountId = accountId;
            this.AccountProfileId = accountProfileId;
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets ServiceListVersion
        /// </summary>
        [DataMember(Name="serviceListVersion", EmitDefaultValue=false)]
        public string ServiceListVersion { get; set; }

        /// <summary>
        /// Gets or Sets BillingAccount
        /// </summary>
        [DataMember(Name="billingAccount", EmitDefaultValue=false)]
        public string BillingAccount { get; set; }

        /// <summary>
        /// Gets or Sets Brn
        /// </summary>
        [DataMember(Name="brn", EmitDefaultValue=false)]
        public int? Brn { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets AccountProfileId
        /// </summary>
        [DataMember(Name="accountProfileId", EmitDefaultValue=false)]
        public int? AccountProfileId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentRequestModel {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ServiceListVersion: ").Append(ServiceListVersion).Append("\n");
            sb.Append("  BillingAccount: ").Append(BillingAccount).Append("\n");
            sb.Append("  Brn: ").Append(Brn).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountProfileId: ").Append(AccountProfileId).Append("\n");
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
            return this.Equals(input as PaymentRequestModel);
        }

        /// <summary>
        /// Returns true if PaymentRequestModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentRequestModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentRequestModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.ServiceListVersion == input.ServiceListVersion ||
                    (this.ServiceListVersion != null &&
                    this.ServiceListVersion.Equals(input.ServiceListVersion))
                ) && 
                (
                    this.BillingAccount == input.BillingAccount ||
                    (this.BillingAccount != null &&
                    this.BillingAccount.Equals(input.BillingAccount))
                ) && 
                (
                    this.Brn == input.Brn ||
                    (this.Brn != null &&
                    this.Brn.Equals(input.Brn))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AccountProfileId == input.AccountProfileId ||
                    (this.AccountProfileId != null &&
                    this.AccountProfileId.Equals(input.AccountProfileId))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ServiceListVersion != null)
                    hashCode = hashCode * 59 + this.ServiceListVersion.GetHashCode();
                if (this.BillingAccount != null)
                    hashCode = hashCode * 59 + this.BillingAccount.GetHashCode();
                if (this.Brn != null)
                    hashCode = hashCode * 59 + this.Brn.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountProfileId != null)
                    hashCode = hashCode * 59 + this.AccountProfileId.GetHashCode();
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
