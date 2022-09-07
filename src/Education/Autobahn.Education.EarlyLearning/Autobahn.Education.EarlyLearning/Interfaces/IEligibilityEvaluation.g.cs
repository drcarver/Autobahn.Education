//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IEligibilityEvaluation.g.cs
//***************************************************************************

/// <summary>
/// The IEligibilityEvaluation file
/// </summary>
public partial interface IEligibilityEvaluation
{
    #region "IEligibilityEvaluation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Eligibility Evaluation Date
    /// <para>
    /// The date when the evaluation to determine eligibility was conducted.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20712">Eligibility Evaluation Date</a>
    /// </para>
    /// </summary>
    DateTime? EvaluationDate { get; set; }

    #endregion
}
