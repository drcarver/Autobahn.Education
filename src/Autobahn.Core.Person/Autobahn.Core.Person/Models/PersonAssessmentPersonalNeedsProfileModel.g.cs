//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonAssessmentPersonalNeedsProfileEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonAssessmentPersonalNeedsProfile file
/// </summary>
public partial class PersonAssessmentPersonalNeedsProfileModel : AutobahnBaseModel, IPersonAssessmentPersonalNeedsProfile
{
    #region "IPersonAssessmentPersonalNeedsProfile Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    public Guid AssessmentPersonalNeedsProfileId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    #endregion
}
