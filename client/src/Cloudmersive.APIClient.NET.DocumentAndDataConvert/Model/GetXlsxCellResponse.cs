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
    /// Result of running a Get-Cell command
    /// </summary>
    [DataContract]
    public partial class GetXlsxCellResponse :  IEquatable<GetXlsxCellResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetXlsxCellResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="cell">Requested Cell in the Excel XLSX document.</param>
        public GetXlsxCellResponse(bool? successful = default(bool?), XlsxSpreadsheetCell cell = default(XlsxSpreadsheetCell))
        {
            this.Successful = successful;
            this.Cell = cell;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Requested Cell in the Excel XLSX document
        /// </summary>
        /// <value>Requested Cell in the Excel XLSX document</value>
        [DataMember(Name="Cell", EmitDefaultValue=false)]
        public XlsxSpreadsheetCell Cell { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetXlsxCellResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Cell: ").Append(Cell).Append("\n");
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
            return this.Equals(input as GetXlsxCellResponse);
        }

        /// <summary>
        /// Returns true if GetXlsxCellResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetXlsxCellResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetXlsxCellResponse input)
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
                    this.Cell == input.Cell ||
                    (this.Cell != null &&
                    this.Cell.Equals(input.Cell))
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
                if (this.Cell != null)
                    hashCode = hashCode * 59 + this.Cell.GetHashCode();
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
