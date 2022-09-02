//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentItemEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormSectionAssessmentItem file
/// </summary>
public partial class AssessmentFormSectionAssessmentItemModel : AutobahnBaseModel, IAssessmentFormSectionAssessmentItem
{
    #region "IAssessmentFormSectionAssessmentItem Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    public Guid AssessmentFormSectionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSectionItem"/> model
    /// </summary>
    public Guid AssessmentFormSectionItemId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    public Guid AssessmentItemId { get; set; }

    public System.Int32 SequenceNumber { get; set; }

    #endregion
}
