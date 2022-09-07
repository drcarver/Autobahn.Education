//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EligibilityEvaluationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IEligibilityEvaluation file
/// </summary>
[Table("EligibilityEvaluation", Schema = "EarlyLearning")]
public partial class EligibilityEvaluationEntity : EntityBase, IEligibilityEvaluation
{
    #region "IEligibilityEvaluation Properties"
    /// <summary>
    /// Eligibility Evaluation Date
    /// <para>
    /// The date when the evaluation to determine eligibility was conducted.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20712">Eligibility Evaluation Date</a>
    /// </para>
    /// </summary>
    [Comment("The date when the evaluation to determine eligibility was conducted.")]
    public DateTime? EvaluationDate { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
