//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionItemEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormSectionItem file
/// </summary>
public partial class AssessmentFormSectionItemModel : AutobahnBaseModel, IAssessmentFormSectionItem
{
    #region "IAssessmentFormSectionItem Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    public Guid AssessmentFormId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    public Guid AssessmentFormSectionId { get; set; }

    public Int32? SequenceNumber { get; set; }

    #endregion
}
