//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentFormSectionAssessmentItem.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormSectionAssessmentItem file
/// </summary>
public partial interface IAssessmentFormSectionAssessmentItem
{
    #region "IAssessmentFormSectionAssessmentItem Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    Guid AssessmentFormSectionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSectionItem"/> model
    /// </summary>
    Guid AssessmentFormSectionItemId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    Guid AssessmentItemId { get; set; }

    System.Int32 SequenceNumber { get; set; }

    #endregion
}
