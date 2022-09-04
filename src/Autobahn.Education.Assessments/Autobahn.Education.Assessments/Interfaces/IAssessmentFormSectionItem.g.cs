//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentFormSectionItem.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormSectionItem file
/// </summary>
public partial interface IAssessmentFormSectionItem
{
    #region "IAssessmentFormSectionItem Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

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
