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
    /// Style in a DOCX Word Document
    /// </summary>
    [DataContract]
    public partial class DocxStyle :  IEquatable<DocxStyle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocxStyle" /> class.
        /// </summary>
        /// <param name="StyleID">ID of the style.</param>
        /// <param name="Bold">Style applies bold formatting.</param>
        /// <param name="Italic">Style applies italic formatting.</param>
        /// <param name="Underline">Style applies underline formatting.</param>
        /// <param name="FontSize">Font size.</param>
        /// <param name="FontFamily">Font family.</param>
        public DocxStyle(string StyleID = default(string), bool? Bold = default(bool?), bool? Italic = default(bool?), bool? Underline = default(bool?), string FontSize = default(string), string FontFamily = default(string))
        {
            this.StyleID = StyleID;
            this.Bold = Bold;
            this.Italic = Italic;
            this.Underline = Underline;
            this.FontSize = FontSize;
            this.FontFamily = FontFamily;
        }
        
        /// <summary>
        /// ID of the style
        /// </summary>
        /// <value>ID of the style</value>
        [DataMember(Name="StyleID", EmitDefaultValue=false)]
        public string StyleID { get; set; }

        /// <summary>
        /// Style applies bold formatting
        /// </summary>
        /// <value>Style applies bold formatting</value>
        [DataMember(Name="Bold", EmitDefaultValue=false)]
        public bool? Bold { get; set; }

        /// <summary>
        /// Style applies italic formatting
        /// </summary>
        /// <value>Style applies italic formatting</value>
        [DataMember(Name="Italic", EmitDefaultValue=false)]
        public bool? Italic { get; set; }

        /// <summary>
        /// Style applies underline formatting
        /// </summary>
        /// <value>Style applies underline formatting</value>
        [DataMember(Name="Underline", EmitDefaultValue=false)]
        public bool? Underline { get; set; }

        /// <summary>
        /// Font size
        /// </summary>
        /// <value>Font size</value>
        [DataMember(Name="FontSize", EmitDefaultValue=false)]
        public string FontSize { get; set; }

        /// <summary>
        /// Font family
        /// </summary>
        /// <value>Font family</value>
        [DataMember(Name="FontFamily", EmitDefaultValue=false)]
        public string FontFamily { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocxStyle {\n");
            sb.Append("  StyleID: ").Append(StyleID).Append("\n");
            sb.Append("  Bold: ").Append(Bold).Append("\n");
            sb.Append("  Italic: ").Append(Italic).Append("\n");
            sb.Append("  Underline: ").Append(Underline).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  FontFamily: ").Append(FontFamily).Append("\n");
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
            return this.Equals(input as DocxStyle);
        }

        /// <summary>
        /// Returns true if DocxStyle instances are equal
        /// </summary>
        /// <param name="input">Instance of DocxStyle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocxStyle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StyleID == input.StyleID ||
                    (this.StyleID != null &&
                    this.StyleID.Equals(input.StyleID))
                ) && 
                (
                    this.Bold == input.Bold ||
                    (this.Bold != null &&
                    this.Bold.Equals(input.Bold))
                ) && 
                (
                    this.Italic == input.Italic ||
                    (this.Italic != null &&
                    this.Italic.Equals(input.Italic))
                ) && 
                (
                    this.Underline == input.Underline ||
                    (this.Underline != null &&
                    this.Underline.Equals(input.Underline))
                ) && 
                (
                    this.FontSize == input.FontSize ||
                    (this.FontSize != null &&
                    this.FontSize.Equals(input.FontSize))
                ) && 
                (
                    this.FontFamily == input.FontFamily ||
                    (this.FontFamily != null &&
                    this.FontFamily.Equals(input.FontFamily))
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
                if (this.StyleID != null)
                    hashCode = hashCode * 59 + this.StyleID.GetHashCode();
                if (this.Bold != null)
                    hashCode = hashCode * 59 + this.Bold.GetHashCode();
                if (this.Italic != null)
                    hashCode = hashCode * 59 + this.Italic.GetHashCode();
                if (this.Underline != null)
                    hashCode = hashCode * 59 + this.Underline.GetHashCode();
                if (this.FontSize != null)
                    hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                if (this.FontFamily != null)
                    hashCode = hashCode * 59 + this.FontFamily.GetHashCode();
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
