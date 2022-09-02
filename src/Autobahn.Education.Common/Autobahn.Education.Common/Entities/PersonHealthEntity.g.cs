//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonHealth file
/// </summary>
[Table("PersonHealth", Schema = "Common")]
public partial class PersonHealthEntity : EntityBase, IPersonHealth
{
    #region "IPersonHealth Properties"
    /// <summary>
    /// Dental Screening Date
    /// <para>
    /// The year, month and day of a dental screening
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19682">Dental Screening Date</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The year, month and day of a dental screening")]
    public System.DateTime DentalScreeningDate { get; set; }

    /// <summary>
    /// Health Screening Equipment Used
    /// <para>
    /// The screening equipment used for the hearing screening or the method used for the vision screening
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20325">Health Screening Equipment Used</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The screening equipment used for the hearing screening or the method used for the vision screening")]
    public System.String HealthScreeningEquipmentUsed { get; set; }

    /// <summary>
    /// Health Screening Follow-up Recommendation
    /// <para>
    /// Recommendations for follow-up after a health screening.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20326">Health Screening Follow-up Recommendation</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Recommendations for follow-up after a health screening.")]
    public System.String HealthScreeningFollowUpRecommendation { get; set; }

    /// <summary>
    /// Hearing Screening Date
    /// <para>
    /// The year, month and day of a hearing screening.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19681">Hearing Screening Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day of a hearing screening.")]
    public DateTime? HearingScreeningDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Dental Insurance Coverage Type
    /// <para>
    /// The source of insurance covering an person's dental care.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19335">Dental Insurance Coverage Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefDentalInsuranceCoverageType")]
    [Comment("The source of insurance covering an person's dental care.")]
    public Guid? RefDentalInsuranceCoverageTypeId { get; set; }

    /// <summary>
    /// Dental Screening Status
    /// <para>
    /// The condition of a person's mouth or oral cavity; more specifically the condition of the hard tissues (i.e., teeth and jaws) and the soft tissues (i.e., gums, tongue, lips, palate, mouth floor, and inner cheeks). Good oral health denotes the absence of clinically manifested disease or abnormalities of the oral cavity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19310">Dental Screening Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefDentalScreeningStatus")]
    [Comment("The condition of a person's mouth or oral cavity; more specifically the condition of the hard tissues (i.e., teeth and jaws) and the soft tissues (i.e., gums, tongue, lips, palate, mouth floor, and inner cheeks). Good oral health denotes the absence of clinically manifested disease or abnormalities of the oral cavity.")]
    public Guid? RefDentalScreeningStatusId { get; set; }

    /// <summary>
    /// Insurance Coverage
    /// <para>
    /// The nature of insurance covering an person's hospitalization and other health or medical care.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19334">Insurance Coverage</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefHealthInsuranceCoverage")]
    [Comment("The nature of insurance covering an person's hospitalization and other health or medical care.")]
    public Guid? RefHealthInsuranceCoverageId { get; set; }

    /// <summary>
    /// Hearing Screening Status
    /// <para>
    /// Status of an examination used to measure a person's ability to perceive sounds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19309">Hearing Screening Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefHearingScreeningStatus")]
    [Comment("Status of an examination used to measure a person's ability to perceive sounds.")]
    public Guid? RefHearingScreeningStatusId { get; set; }

    /// <summary>
    /// Medical Alert Indicator
    /// <para>
    /// Alert indicator for a medical/health condition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19429">Medical Alert Indicator</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefMedicalAlertIndicator")]
    [Comment("Alert indicator for a medical/health condition.")]
    public Guid? RefMedicalAlertIndicatorId { get; set; }

    /// <summary>
    /// Vision Screening Status
    /// <para>
    /// Status of an examination used to measure a person's ability to see.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19308">Vision Screening Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefVisionScreeningStatus")]
    [Comment("Status of an examination used to measure a person's ability to see.")]
    public Guid? RefVisionScreeningStatusId { get; set; }

    /// <summary>
    /// Vision Screening Date
    /// <para>
    /// The year, month and day of a vision screening.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19680">Vision Screening Date</a>
    /// </para>
    /// </summary>
    [Comment("The year, month and day of a vision screening.")]
    public DateTime? VisionScreeningDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Status of an examination used to measure a person's ability to see.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19308">Vision Screening Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefVisionScreeningStatusEntity RefVisionScreeningStatusEntity { get; set; }

    /// <summary>
    /// Status of an examination used to measure a person's ability to perceive sounds.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19309">Hearing Screening Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefHearingScreeningStatusEntity RefHearingScreeningStatusEntity { get; set; }

    /// <summary>
    /// The condition of a person's mouth or oral cavity; more specifically the condition of the hard tissues (i.e., teeth and jaws) and the soft tissues (i.e., gums, tongue, lips, palate, mouth floor, and inner cheeks). Good oral health denotes the absence of clinically manifested disease or abnormalities of the oral cavity.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19310">Dental Screening Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefDentalScreeningStatusEntity RefDentalScreeningStatusEntity { get; set; }

    /// <summary>
    /// The nature of insurance covering an person's hospitalization and other health or medical care.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19334">Insurance Coverage</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefHealthInsuranceCoverageEntity RefHealthInsuranceCoverageEntity { get; set; }

    /// <summary>
    /// The source of insurance covering an person's dental care.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19335">Dental Insurance Coverage Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefDentalInsuranceCoverageTypeEntity RefDentalInsuranceCoverageTypeEntity { get; set; }

    /// <summary>
    /// Alert indicator for a medical/health condition.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19429">Medical Alert Indicator</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefMedicalAlertIndicatorEntity RefMedicalAlertIndicatorEntity { get; set; }

    #endregion
}
