//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElchildDevelopmentalAssessment.g.cs
//***************************************************************************

/// <summary>
/// The IElchildDevelopmentalAssessment file
/// </summary>
public partial interface IElchildDevelopmentalAssessment
{
    #region "IElchildDevelopmentalAssessment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefChildDevelopmentalScreeningStatus"/> model
    /// </summary>
    Guid? RefChildDevelopmentalScreeningStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDevelopmentalEvaluationFinding"/> model
    /// </summary>
    Guid? RefDevelopmentalEvaluationFindingId { get; set; }

    #endregion
}
