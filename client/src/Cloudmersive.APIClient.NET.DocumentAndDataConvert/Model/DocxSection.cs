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
    /// Section of a Word Document (DOCX)
    /// </summary>
    [DataContract]
    public partial class DocxSection :  IEquatable<DocxSection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocxSection" /> class.
        /// </summary>
        /// <param name="StartingPageNumbers">Page numbers that the section starts at, typically just one.</param>
        public DocxSection(List<int?> StartingPageNumbers = default(List<int?>))
        {
            this.StartingPageNumbers = StartingPageNumbers;
        }
        
        /// <summary>
        /// Page numbers that the section starts at, typically just one
        /// </summary>
        /// <value>Page numbers that the section starts at, typically just one</value>
        [DataMember(Name="StartingPageNumbers", EmitDefaultValue=false)]
        public List<int?> StartingPageNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocxSection {\n");
            sb.Append("  StartingPageNumbers: ").Append(StartingPageNumbers).Append("\n");
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
            return this.Equals(input as DocxSection);
        }

        /// <summary>
        /// Returns true if DocxSection instances are equal
        /// </summary>
        /// <param name="input">Instance of DocxSection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocxSection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartingPageNumbers == input.StartingPageNumbers ||
                    this.StartingPageNumbers != null &&
                    this.StartingPageNumbers.SequenceEqual(input.StartingPageNumbers)
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
                if (this.StartingPageNumbers != null)
                    hashCode = hashCode * 59 + this.StartingPageNumbers.GetHashCode();
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