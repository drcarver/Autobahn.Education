//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubTestEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubTest file
/// </summary>
public partial class AssessmentSubTestModel : AutobahnBaseModel, IAssessmentSubTest
{
    #region "IAssessmentSubTest Properties"
    public System.String Abbreviation { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    public Guid? AssessmentFormId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IChildOfAssessmentSubtest"/> model
    /// </summary>
    public Guid? ChildOfAssessmentSubtestId { get; set; }

    public System.String ContainerOnly { get; set; }

    public System.String Identifier { get; set; }

    public System.String MaximumValue { get; set; }

    public System.String MinimumValue { get; set; }

    public System.String OptimalValue { get; set; }

    public DateTime? PublishedDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAcademicSubject"/> model
    /// </summary>
    public Guid? RefAcademicSubjectId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
    /// </summary>
    public Guid? RefAssessmentPurposeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentSubtestentifierType"/> model
    /// </summary>
    public Guid? RefAssessmentSubtestIdentifierTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefContentStandardType"/> model
    /// </summary>
    public Guid? RefContentStandardTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScoreMetricType"/> model
    /// </summary>
    public Guid? RefScoreMetricTypeId { get; set; }

    public System.String Rules { get; set; }

    public Int32? Tier { get; set; }

    public System.String Title { get; set; }

    public System.String Version { get; set; }

    #endregion
}
