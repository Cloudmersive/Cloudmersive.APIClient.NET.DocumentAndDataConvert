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
    /// Result of performing a batch job operation
    /// </summary>
    [DataContract]
    public partial class ConvertDocumentJobStatusResult :  IEquatable<ConvertDocumentJobStatusResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentJobStatusResult" /> class.
        /// </summary>
        /// <param name="successful">Tru eif the operation to check the status of the job was successful, false otherwise.</param>
        /// <param name="asyncJobStatus">Returns the job status of the Async Job, if applicable.  Possible states are STARTED and COMPLETED.</param>
        /// <param name="asyncJobID">When the job exceeds 25 pages, an Async Job ID is returned.  Use the CheckPdfOcrJobStatus API to check on the status of this job using the AsyncJobID and get the result when it finishes.</param>
        /// <param name="outputFileResult">Output file result (if applicable).</param>
        /// <param name="errorMessage">Error message (if any).</param>
        public ConvertDocumentJobStatusResult(bool? successful = default(bool?), string asyncJobStatus = default(string), string asyncJobID = default(string), byte[] outputFileResult = default(byte[]), string errorMessage = default(string))
        {
            this.Successful = successful;
            this.AsyncJobStatus = asyncJobStatus;
            this.AsyncJobID = asyncJobID;
            this.OutputFileResult = outputFileResult;
            this.ErrorMessage = errorMessage;
        }
        
        /// <summary>
        /// Tru eif the operation to check the status of the job was successful, false otherwise
        /// </summary>
        /// <value>Tru eif the operation to check the status of the job was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Returns the job status of the Async Job, if applicable.  Possible states are STARTED and COMPLETED
        /// </summary>
        /// <value>Returns the job status of the Async Job, if applicable.  Possible states are STARTED and COMPLETED</value>
        [DataMember(Name="AsyncJobStatus", EmitDefaultValue=false)]
        public string AsyncJobStatus { get; set; }

        /// <summary>
        /// When the job exceeds 25 pages, an Async Job ID is returned.  Use the CheckPdfOcrJobStatus API to check on the status of this job using the AsyncJobID and get the result when it finishes
        /// </summary>
        /// <value>When the job exceeds 25 pages, an Async Job ID is returned.  Use the CheckPdfOcrJobStatus API to check on the status of this job using the AsyncJobID and get the result when it finishes</value>
        [DataMember(Name="AsyncJobID", EmitDefaultValue=false)]
        public string AsyncJobID { get; set; }

        /// <summary>
        /// Output file result (if applicable)
        /// </summary>
        /// <value>Output file result (if applicable)</value>
        [DataMember(Name="OutputFileResult", EmitDefaultValue=false)]
        public byte[] OutputFileResult { get; set; }

        /// <summary>
        /// Error message (if any)
        /// </summary>
        /// <value>Error message (if any)</value>
        [DataMember(Name="ErrorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertDocumentJobStatusResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  AsyncJobStatus: ").Append(AsyncJobStatus).Append("\n");
            sb.Append("  AsyncJobID: ").Append(AsyncJobID).Append("\n");
            sb.Append("  OutputFileResult: ").Append(OutputFileResult).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(input as ConvertDocumentJobStatusResult);
        }

        /// <summary>
        /// Returns true if ConvertDocumentJobStatusResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ConvertDocumentJobStatusResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvertDocumentJobStatusResult input)
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
                    this.AsyncJobStatus == input.AsyncJobStatus ||
                    (this.AsyncJobStatus != null &&
                    this.AsyncJobStatus.Equals(input.AsyncJobStatus))
                ) && 
                (
                    this.AsyncJobID == input.AsyncJobID ||
                    (this.AsyncJobID != null &&
                    this.AsyncJobID.Equals(input.AsyncJobID))
                ) && 
                (
                    this.OutputFileResult == input.OutputFileResult ||
                    (this.OutputFileResult != null &&
                    this.OutputFileResult.Equals(input.OutputFileResult))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.AsyncJobStatus != null)
                    hashCode = hashCode * 59 + this.AsyncJobStatus.GetHashCode();
                if (this.AsyncJobID != null)
                    hashCode = hashCode * 59 + this.AsyncJobID.GetHashCode();
                if (this.OutputFileResult != null)
                    hashCode = hashCode * 59 + this.OutputFileResult.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
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
