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
    /// Result of running a DocxGetFormFields command
    /// </summary>
    [DataContract]
    public partial class GetDocxGetFormFieldsResponse :  IEquatable<GetDocxGetFormFieldsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocxGetFormFieldsResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="contentControls">Content controls in the DOCX.</param>
        /// <param name="handlebarFormFields">Form fields that comply with the Handlebar style, that is they are surrounded by two curly braces on either side such as \&quot;{{FieldName}}\&quot;, in the DOCX.</param>
        public GetDocxGetFormFieldsResponse(bool? successful = default(bool?), List<DocxContentControl> contentControls = default(List<DocxContentControl>), List<HandlebarFormField> handlebarFormFields = default(List<HandlebarFormField>))
        {
            this.Successful = successful;
            this.ContentControls = contentControls;
            this.HandlebarFormFields = handlebarFormFields;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Content controls in the DOCX
        /// </summary>
        /// <value>Content controls in the DOCX</value>
        [DataMember(Name="ContentControls", EmitDefaultValue=false)]
        public List<DocxContentControl> ContentControls { get; set; }

        /// <summary>
        /// Form fields that comply with the Handlebar style, that is they are surrounded by two curly braces on either side such as \&quot;{{FieldName}}\&quot;, in the DOCX
        /// </summary>
        /// <value>Form fields that comply with the Handlebar style, that is they are surrounded by two curly braces on either side such as \&quot;{{FieldName}}\&quot;, in the DOCX</value>
        [DataMember(Name="HandlebarFormFields", EmitDefaultValue=false)]
        public List<HandlebarFormField> HandlebarFormFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocxGetFormFieldsResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  ContentControls: ").Append(ContentControls).Append("\n");
            sb.Append("  HandlebarFormFields: ").Append(HandlebarFormFields).Append("\n");
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
            return this.Equals(input as GetDocxGetFormFieldsResponse);
        }

        /// <summary>
        /// Returns true if GetDocxGetFormFieldsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocxGetFormFieldsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocxGetFormFieldsResponse input)
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
                    this.ContentControls == input.ContentControls ||
                    this.ContentControls != null &&
                    this.ContentControls.SequenceEqual(input.ContentControls)
                ) && 
                (
                    this.HandlebarFormFields == input.HandlebarFormFields ||
                    this.HandlebarFormFields != null &&
                    this.HandlebarFormFields.SequenceEqual(input.HandlebarFormFields)
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
                if (this.ContentControls != null)
                    hashCode = hashCode * 59 + this.ContentControls.GetHashCode();
                if (this.HandlebarFormFields != null)
                    hashCode = hashCode * 59 + this.HandlebarFormFields.GetHashCode();
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