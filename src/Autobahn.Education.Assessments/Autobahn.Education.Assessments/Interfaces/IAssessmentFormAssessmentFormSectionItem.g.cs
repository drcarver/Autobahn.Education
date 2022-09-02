//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentFormAssessmentFormSectionItem.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormAssessmentFormSectionItem file
/// </summary>
public partial interface IAssessmentFormAssessmentFormSectionItem
{
    #region "IAssessmentFormAssessmentFormSectionItem Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormAssessmentFormSection"/> model
    /// </summary>
    Guid AssessmentFormAssessmentFormSectionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    Guid AssessmentFormId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    Guid AssessmentFormSectionId { get; set; }

    Int32? SequenceNumber { get; set; }

    #endregion
}
