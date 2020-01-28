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
    /// Request to find a string in a string
    /// </summary>
    [DataContract]
    public partial class FindStringRegexRequest :  IEquatable<FindStringRegexRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindStringRegexRequest" /> class.
        /// </summary>
        /// <param name="textContent">Input text content.</param>
        /// <param name="targetRegex">Target input regular expression (regex) to find.</param>
        /// <param name="matchCase">Set to True to match case, False to ignore case.</param>
        public FindStringRegexRequest(string textContent = default(string), string targetRegex = default(string), bool? matchCase = default(bool?))
        {
            this.TextContent = textContent;
            this.TargetRegex = targetRegex;
            this.MatchCase = matchCase;
        }
        
        /// <summary>
        /// Input text content
        /// </summary>
        /// <value>Input text content</value>
        [DataMember(Name="TextContent", EmitDefaultValue=false)]
        public string TextContent { get; set; }

        /// <summary>
        /// Target input regular expression (regex) to find
        /// </summary>
        /// <value>Target input regular expression (regex) to find</value>
        [DataMember(Name="TargetRegex", EmitDefaultValue=false)]
        public string TargetRegex { get; set; }

        /// <summary>
        /// Set to True to match case, False to ignore case
        /// </summary>
        /// <value>Set to True to match case, False to ignore case</value>
        [DataMember(Name="MatchCase", EmitDefaultValue=false)]
        public bool? MatchCase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindStringRegexRequest {\n");
            sb.Append("  TextContent: ").Append(TextContent).Append("\n");
            sb.Append("  TargetRegex: ").Append(TargetRegex).Append("\n");
            sb.Append("  MatchCase: ").Append(MatchCase).Append("\n");
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
            return this.Equals(input as FindStringRegexRequest);
        }

        /// <summary>
        /// Returns true if FindStringRegexRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FindStringRegexRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindStringRegexRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TextContent == input.TextContent ||
                    (this.TextContent != null &&
                    this.TextContent.Equals(input.TextContent))
                ) && 
                (
                    this.TargetRegex == input.TargetRegex ||
                    (this.TargetRegex != null &&
                    this.TargetRegex.Equals(input.TargetRegex))
                ) && 
                (
                    this.MatchCase == input.MatchCase ||
                    (this.MatchCase != null &&
                    this.MatchCase.Equals(input.MatchCase))
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
                if (this.TextContent != null)
                    hashCode = hashCode * 59 + this.TextContent.GetHashCode();
                if (this.TargetRegex != null)
                    hashCode = hashCode * 59 + this.TargetRegex.GetHashCode();
                if (this.MatchCase != null)
                    hashCode = hashCode * 59 + this.MatchCase.GetHashCode();
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
