//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestEldevelopmentalDomainEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestEldevelopmentalDomain file
/// </summary>
public partial class AssessmentSubtestEldevelopmentalDomainModel : AutobahnBaseModel, IAssessmentSubtestEldevelopmentalDomain
{
    #region "IAssessmentSubtestEldevelopmentalDomain Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
    /// </summary>
    public Guid AssessmentSubtestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
    /// </summary>
    public Guid RefAssessmentEldevelopmentalDomainId { get; set; }

    #endregion
}
