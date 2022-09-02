//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElchildDevelopmentalAssessmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildDevelopmentalAssessment file
/// </summary>
public partial class ElchildDevelopmentalAssessmentModel : AutobahnBaseModel, IElchildDevelopmentalAssessment
{
    #region "IElchildDevelopmentalAssessment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefChildDevelopmentalScreeningStatus"/> model
    /// </summary>
    public Guid? RefChildDevelopmentalScreeningStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDevelopmentalEvaluationFinding"/> model
    /// </summary>
    public Guid? RefDevelopmentalEvaluationFindingId { get; set; }

    #endregion
}
