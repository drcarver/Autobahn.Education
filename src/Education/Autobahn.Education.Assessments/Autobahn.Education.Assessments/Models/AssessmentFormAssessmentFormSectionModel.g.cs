//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentFormSectionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormAssessmentFormSection file
/// </summary>
public partial class AssessmentFormAssessmentFormSectionModel : AutobahnBaseModel, IAssessmentFormAssessmentFormSection
{
    #region "IAssessmentFormAssessmentFormSection Properties"
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
