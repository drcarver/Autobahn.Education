//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentFormSectionItemEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormAssessmentFormSectionItem file
/// </summary>
public partial class AssessmentFormAssessmentFormSectionItemModel : AutobahnBaseModel, IAssessmentFormAssessmentFormSectionItem
{
    #region "IAssessmentFormAssessmentFormSectionItem Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormAssessmentFormSection"/> model
    /// </summary>
    public Guid AssessmentFormAssessmentFormSectionId { get; set; }

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
