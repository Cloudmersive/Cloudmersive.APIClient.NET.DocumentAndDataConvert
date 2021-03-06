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
    /// Input to a Remove Word DOCX Document Pages request
    /// </summary>
    [DataContract]
    public partial class RemoveDocxPagesRequest :  IEquatable<RemoveDocxPagesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveDocxPagesRequest" /> class.
        /// </summary>
        /// <param name="inputFileBytes">Optional: Bytes of the input file to operate on.</param>
        /// <param name="inputFileUrl">Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public)..</param>
        /// <param name="startDeletePageNumber">Page number (1-based) to start deleting pages; inclusive.</param>
        /// <param name="endDeletePageNumber">Page number (1-based) to stop deleting pages; inclusive.</param>
        public RemoveDocxPagesRequest(byte[] inputFileBytes = default(byte[]), string inputFileUrl = default(string), int? startDeletePageNumber = default(int?), int? endDeletePageNumber = default(int?))
        {
            this.InputFileBytes = inputFileBytes;
            this.InputFileUrl = inputFileUrl;
            this.StartDeletePageNumber = startDeletePageNumber;
            this.EndDeletePageNumber = endDeletePageNumber;
        }
        
        /// <summary>
        /// Optional: Bytes of the input file to operate on
        /// </summary>
        /// <value>Optional: Bytes of the input file to operate on</value>
        [DataMember(Name="InputFileBytes", EmitDefaultValue=false)]
        public byte[] InputFileBytes { get; set; }

        /// <summary>
        /// Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public).
        /// </summary>
        /// <value>Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public).</value>
        [DataMember(Name="InputFileUrl", EmitDefaultValue=false)]
        public string InputFileUrl { get; set; }

        /// <summary>
        /// Page number (1-based) to start deleting pages; inclusive
        /// </summary>
        /// <value>Page number (1-based) to start deleting pages; inclusive</value>
        [DataMember(Name="StartDeletePageNumber", EmitDefaultValue=false)]
        public int? StartDeletePageNumber { get; set; }

        /// <summary>
        /// Page number (1-based) to stop deleting pages; inclusive
        /// </summary>
        /// <value>Page number (1-based) to stop deleting pages; inclusive</value>
        [DataMember(Name="EndDeletePageNumber", EmitDefaultValue=false)]
        public int? EndDeletePageNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveDocxPagesRequest {\n");
            sb.Append("  InputFileBytes: ").Append(InputFileBytes).Append("\n");
            sb.Append("  InputFileUrl: ").Append(InputFileUrl).Append("\n");
            sb.Append("  StartDeletePageNumber: ").Append(StartDeletePageNumber).Append("\n");
            sb.Append("  EndDeletePageNumber: ").Append(EndDeletePageNumber).Append("\n");
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
            return this.Equals(input as RemoveDocxPagesRequest);
        }

        /// <summary>
        /// Returns true if RemoveDocxPagesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoveDocxPagesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveDocxPagesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InputFileBytes == input.InputFileBytes ||
                    (this.InputFileBytes != null &&
                    this.InputFileBytes.Equals(input.InputFileBytes))
                ) && 
                (
                    this.InputFileUrl == input.InputFileUrl ||
                    (this.InputFileUrl != null &&
                    this.InputFileUrl.Equals(input.InputFileUrl))
                ) && 
                (
                    this.StartDeletePageNumber == input.StartDeletePageNumber ||
                    (this.StartDeletePageNumber != null &&
                    this.StartDeletePageNumber.Equals(input.StartDeletePageNumber))
                ) && 
                (
                    this.EndDeletePageNumber == input.EndDeletePageNumber ||
                    (this.EndDeletePageNumber != null &&
                    this.EndDeletePageNumber.Equals(input.EndDeletePageNumber))
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
                if (this.InputFileBytes != null)
                    hashCode = hashCode * 59 + this.InputFileBytes.GetHashCode();
                if (this.InputFileUrl != null)
                    hashCode = hashCode * 59 + this.InputFileUrl.GetHashCode();
                if (this.StartDeletePageNumber != null)
                    hashCode = hashCode * 59 + this.StartDeletePageNumber.GetHashCode();
                if (this.EndDeletePageNumber != null)
                    hashCode = hashCode * 59 + this.EndDeletePageNumber.GetHashCode();
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
