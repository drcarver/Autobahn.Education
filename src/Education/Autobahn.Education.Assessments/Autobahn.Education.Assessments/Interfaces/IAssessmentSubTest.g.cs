//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentSubTest.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubTest file
/// </summary>
public partial interface IAssessmentSubTest
{
    #region "IAssessmentSubTest Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String Abbreviation { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    Guid? AssessmentFormId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IChildOfAssessmentSubtest"/> model
    /// </summary>
    Guid? ChildOfAssessmentSubtestId { get; set; }

    System.String ContainerOnly { get; set; }

    System.String Identifier { get; set; }

    System.String MaximumValue { get; set; }

    System.String MinimumValue { get; set; }

    System.String OptimalValue { get; set; }

    DateTime? PublishedDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAcademicSubject"/> model
    /// </summary>
    Guid? RefAcademicSubjectId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
    /// </summary>
    Guid? RefAssessmentPurposeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentSubtestentifierType"/> model
    /// </summary>
    Guid? RefAssessmentSubtestIdentifierTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefContentStandardType"/> model
    /// </summary>
    Guid? RefContentStandardTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScoreMetricType"/> model
    /// </summary>
    Guid? RefScoreMetricTypeId { get; set; }

    System.String Rules { get; set; }

    Int32? Tier { get; set; }

    System.String Title { get; set; }

    System.String Version { get; set; }

    #endregion
}
