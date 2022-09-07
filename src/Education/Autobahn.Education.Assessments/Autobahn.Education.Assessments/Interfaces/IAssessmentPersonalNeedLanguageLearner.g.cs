//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentPersonalNeedLanguageLearner.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedLanguageLearner file
/// </summary>
public partial interface IAssessmentPersonalNeedLanguageLearner
{
    #region "IAssessmentPersonalNeedLanguageLearner Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Assessment Personal Needs Profile Activate by Default
    /// <para>
    /// Determines if the alternative accessible content is rendered as the default content for the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20008">Assessment Personal Needs Profile Activate by Default</a>
    /// </para>
    /// </summary>
    Boolean? ActivateByDefault { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileContent"/> model
    /// </summary>
    Guid AssessmentPersonalNeedsProfileContentId { get; set; }

    /// <summary>
    /// Assessment Personal Needs Profile Assigned Support
    /// <para>
    /// Defines whether or not the individual needs the kind of support defined by the entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20007">Assessment Personal Needs Profile Assigned Support</a>
    /// </para>
    /// </summary>
    Boolean? AssignedSupport { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentNeedLanguageLearnerType"/> model
    /// </summary>
    Guid RefAssessmentNeedLanguageLearnerTypeId { get; set; }

    #endregion
}
