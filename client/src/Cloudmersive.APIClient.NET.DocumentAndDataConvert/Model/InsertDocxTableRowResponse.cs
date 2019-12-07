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
    /// Result of running an Insert-Table Row command
    /// </summary>
    [DataContract]
    public partial class InsertDocxTableRowResponse :  IEquatable<InsertDocxTableRowResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDocxTableRowResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="editedDocumentURL">URL to the edited DOCX file; file is stored in an in-memory cache and will be deleted.  Call Finish-Editing to get the result document contents..</param>
        public InsertDocxTableRowResponse(bool? successful = default(bool?), string editedDocumentURL = default(string))
        {
            this.Successful = successful;
            this.EditedDocumentURL = editedDocumentURL;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// URL to the edited DOCX file; file is stored in an in-memory cache and will be deleted.  Call Finish-Editing to get the result document contents.
        /// </summary>
        /// <value>URL to the edited DOCX file; file is stored in an in-memory cache and will be deleted.  Call Finish-Editing to get the result document contents.</value>
        [DataMember(Name="EditedDocumentURL", EmitDefaultValue=false)]
        public string EditedDocumentURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsertDocxTableRowResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  EditedDocumentURL: ").Append(EditedDocumentURL).Append("\n");
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
            return this.Equals(input as InsertDocxTableRowResponse);
        }

        /// <summary>
        /// Returns true if InsertDocxTableRowResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InsertDocxTableRowResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsertDocxTableRowResponse input)
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
                    this.EditedDocumentURL == input.EditedDocumentURL ||
                    (this.EditedDocumentURL != null &&
                    this.EditedDocumentURL.Equals(input.EditedDocumentURL))
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
                if (this.EditedDocumentURL != null)
                    hashCode = hashCode * 59 + this.EditedDocumentURL.GetHashCode();
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
