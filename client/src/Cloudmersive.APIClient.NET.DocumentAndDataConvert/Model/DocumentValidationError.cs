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
    /// Validation error found in document
    /// </summary>
    [DataContract]
    public partial class DocumentValidationError :  IEquatable<DocumentValidationError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentValidationError" /> class.
        /// </summary>
        /// <param name="Description">Description of the error.</param>
        /// <param name="Path">XPath to the error.</param>
        /// <param name="Uri">URI of the part in question.</param>
        /// <param name="IsError">True if this is an error, false otherwise.</param>
        public DocumentValidationError(string Description = default(string), string Path = default(string), string Uri = default(string), bool? IsError = default(bool?))
        {
            this.Description = Description;
            this.Path = Path;
            this.Uri = Uri;
            this.IsError = IsError;
        }
        
        /// <summary>
        /// Description of the error
        /// </summary>
        /// <value>Description of the error</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// XPath to the error
        /// </summary>
        /// <value>XPath to the error</value>
        [DataMember(Name="Path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// URI of the part in question
        /// </summary>
        /// <value>URI of the part in question</value>
        [DataMember(Name="Uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// True if this is an error, false otherwise
        /// </summary>
        /// <value>True if this is an error, false otherwise</value>
        [DataMember(Name="IsError", EmitDefaultValue=false)]
        public bool? IsError { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentValidationError {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  IsError: ").Append(IsError).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as DocumentValidationError);
        }

        /// <summary>
        /// Returns true if DocumentValidationError instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentValidationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentValidationError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.IsError == input.IsError ||
                    (this.IsError != null &&
                    this.IsError.Equals(input.IsError))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.IsError != null)
                    hashCode = hashCode * 59 + this.IsError.GetHashCode();
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