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
    /// A single line of a Text document
    /// </summary>
    [DataContract]
    public partial class TextDocumentLine :  IEquatable<TextDocumentLine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextDocumentLine" /> class.
        /// </summary>
        /// <param name="lineNumber">The 1-based line index of the line.</param>
        /// <param name="lineContents">The text contents of a single line of a text file.</param>
        public TextDocumentLine(int? lineNumber = default(int?), string lineContents = default(string))
        {
            this.LineNumber = lineNumber;
            this.LineContents = lineContents;
        }
        
        /// <summary>
        /// The 1-based line index of the line
        /// </summary>
        /// <value>The 1-based line index of the line</value>
        [DataMember(Name="LineNumber", EmitDefaultValue=false)]
        public int? LineNumber { get; set; }

        /// <summary>
        /// The text contents of a single line of a text file
        /// </summary>
        /// <value>The text contents of a single line of a text file</value>
        [DataMember(Name="LineContents", EmitDefaultValue=false)]
        public string LineContents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextDocumentLine {\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  LineContents: ").Append(LineContents).Append("\n");
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
            return this.Equals(input as TextDocumentLine);
        }

        /// <summary>
        /// Returns true if TextDocumentLine instances are equal
        /// </summary>
        /// <param name="input">Instance of TextDocumentLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextDocumentLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineNumber == input.LineNumber ||
                    (this.LineNumber != null &&
                    this.LineNumber.Equals(input.LineNumber))
                ) && 
                (
                    this.LineContents == input.LineContents ||
                    (this.LineContents != null &&
                    this.LineContents.Equals(input.LineContents))
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
                if (this.LineNumber != null)
                    hashCode = hashCode * 59 + this.LineNumber.GetHashCode();
                if (this.LineContents != null)
                    hashCode = hashCode * 59 + this.LineContents.GetHashCode();
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
