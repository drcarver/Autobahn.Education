//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramEligibilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramEligibility file
/// </summary>
public partial class IndividualizedProgramEligibilityModel : AutobahnBaseModel, IIndividualizedProgramEligibility
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
    public Boolean? ConsentToEvaluateIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
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
    public System.String ParentObservations { get; set; }

    #endregion
}
