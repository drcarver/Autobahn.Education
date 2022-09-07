//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IIndividualizedProgramEligibility.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramEligibility file
/// </summary>
public partial interface IIndividualizedProgramEligibility
{
    #region "IIndividualizedProgramEligibility Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Consent to Evaluation Date
    /// <para>
    /// The date the consent to evaluation occurred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20708">Consent to Evaluation Date</a>
    /// </para>
    /// </summary>
    DateTime? ConsentToEvaluateDate { get; set; }

    /// <summary>
    /// Consent to Evaluation Indicator
    /// <para>
    /// Indication parent agreed to evaluate student.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20707">Consent to Evaluation Indicator</a>
    /// </para>
    /// </summary>
    Boolean? ConsentToEvaluateIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    Guid IndividualizedProgramId { get; set; }

    /// <summary>
    /// Eligibility Parent Observations Explanation
    /// <para>
    /// Explanation of parent's observations of student's characteristics and history used for determining eligibility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20713">Eligibility Parent Observations Explanation</a>
    /// </para>
    /// </summary>
    System.String ParentObservations { get; set; }

    #endregion
}
