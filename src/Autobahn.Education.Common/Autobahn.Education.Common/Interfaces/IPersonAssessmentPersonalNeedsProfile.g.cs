//***************************************************************************
//* DomainName: Common Models
//* FileName:   IPersonAssessmentPersonalNeedsProfile.g.cs
//***************************************************************************

/// <summary>
/// The IPersonAssessmentPersonalNeedsProfile file
/// </summary>
public partial interface IPersonAssessmentPersonalNeedsProfile
{
    #region "IPersonAssessmentPersonalNeedsProfile Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    Guid AssessmentPersonalNeedsProfileId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    #endregion
}
