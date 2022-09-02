//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonHealth file
/// </summary>
public partial class PersonHealthModel : AutobahnBaseModel, IPersonHealth
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
    public DateTime? HearingScreeningDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
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
    public DateTime? VisionScreeningDate { get; set; }

    #endregion
}
