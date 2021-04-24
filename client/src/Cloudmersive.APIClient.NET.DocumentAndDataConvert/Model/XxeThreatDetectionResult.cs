/* 
 * convertapi
 *
 * Convert API lets you effortlessly convert file formats and types.
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
using SwaggerDateConverter = Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model
{
    /// <summary>
    /// Result of performing an XXE threat detection operation
    /// </summary>
    [DataContract]
    public partial class XxeThreatDetectionResult :  IEquatable<XxeThreatDetectionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XxeThreatDetectionResult" /> class.
        /// </summary>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        /// <param name="containsXxeThreat">True if the XML input contains XXE threats, false otherwise.</param>
        public XxeThreatDetectionResult(bool? successful = default(bool?), bool? containsXxeThreat = default(bool?))
        {
            this.Successful = successful;
            this.ContainsXxeThreat = containsXxeThreat;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// True if the XML input contains XXE threats, false otherwise
        /// </summary>
        /// <value>True if the XML input contains XXE threats, false otherwise</value>
        [DataMember(Name="ContainsXxeThreat", EmitDefaultValue=false)]
        public bool? ContainsXxeThreat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XxeThreatDetectionResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  ContainsXxeThreat: ").Append(ContainsXxeThreat).Append("\n");
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
            return this.Equals(input as XxeThreatDetectionResult);
        }

        /// <summary>
        /// Returns true if XxeThreatDetectionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of XxeThreatDetectionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XxeThreatDetectionResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.ContainsXxeThreat == input.ContainsXxeThreat ||
                    (this.ContainsXxeThreat != null &&
                    this.ContainsXxeThreat.Equals(input.ContainsXxeThreat))
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.ContainsXxeThreat != null)
                    hashCode = hashCode * 59 + this.ContainsXxeThreat.GetHashCode();
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
