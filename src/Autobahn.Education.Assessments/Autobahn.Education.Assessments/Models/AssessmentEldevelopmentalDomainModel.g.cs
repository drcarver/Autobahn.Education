//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentEldevelopmentalDomainEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentEldevelopmentalDomain file
/// </summary>
public partial class AssessmentEldevelopmentalDomainModel : AutobahnBaseModel, IAssessmentEldevelopmentalDomain
{
    #region "IAssessmentEldevelopmentalDomain Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    public Guid AssessmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
    /// </summary>
    public Guid RefAssessmentEldevelopmentalDomainId { get; set; }

    #endregion
}
