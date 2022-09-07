//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramEligibilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramEligibility file
/// </summary>
[Table("IndividualizedProgramEligibility", Schema = "Invalid")]
public partial class IndividualizedProgramEligibilityEntity : EntityBase, IIndividualizedProgramEligibility
{
    #region "IIndividualizedProgramEligibility Properties"
    /// <summary>
    /// Consent to Evaluation Date
    /// <para>
    /// The date the consent to evaluation occurred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20708">Consent to Evaluation Date</a>
    /// </para>
    /// </summary>
    [Comment("The date the consent to evaluation occurred.")]
    public DateTime? ConsentToEvaluateDate { get; set; }

    /// <summary>
    /// Consent to Evaluation Indicator
    /// <para>
    /// Indication parent agreed to evaluate student.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20707">Consent to Evaluation Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indication parent agreed to evaluate student.")]
    public Boolean? ConsentToEvaluateIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgram")]
    public Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Eligibility Parent Observations Explanation
    /// <para>
    /// Explanation of parent's observations of student's characteristics and history used for determining eligibility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20713">Eligibility Parent Observations Explanation</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("Explanation of parent's observations of student's characteristics and history used for determining eligibility.")]
    public System.String ParentObservations { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramEntity IndividualizedProgramEntity { get; set; }

    #endregion
}
