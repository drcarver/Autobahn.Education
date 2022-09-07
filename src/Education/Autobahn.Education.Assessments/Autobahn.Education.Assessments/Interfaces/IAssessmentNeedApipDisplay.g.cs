//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentNeedApipDisplay.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentNeedApipDisplay file
/// </summary>
public partial interface IAssessmentNeedApipDisplay
{
    #region "IAssessmentNeedApipDisplay Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> model
    /// </summary>
    Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

    /// <summary>
    /// Assessment Personal Needs Profile Activate by Default
    /// <para>
    /// Determines if the alternative accessible content is rendered as the default content for the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20008">Assessment Personal Needs Profile Activate by Default</a>
    /// </para>
    /// </summary>
    Boolean? EncouragementActivateByDefaultIndicator { get; set; }

    /// <summary>
    /// Assessment Personal Needs Profile Assigned Support
    /// <para>
    /// Defines whether or not the individual needs the kind of support defined by the entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20007">Assessment Personal Needs Profile Assigned Support</a>
    /// </para>
    /// </summary>
    Boolean? EncouragementAssignedSupportIndicator { get; set; }

    /// <summary>
    /// Assessment Need Sound File URL
    /// <para>
    /// The URI of the sound file that is to be played to the user as an expression of encouragement when Masking is specified as part of an Assessment Personal Needs Profile. It is left to the system to determine when to play this audio file.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20053">Assessment Need Sound File URL</a>
    /// </para>
    /// </summary>
    System.String EncouragementSoundFileUrl { get; set; }

    /// <summary>
    /// Assessment Need Text Messaging String
    /// <para>
    /// The text string that is to be displayed to the user as an expression of encouragement when Masking is specified as part of an Assessment Personal Needs Profile.  It is left to the system to determine when to display this string.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20052">Assessment Need Text Messaging String</a>
    /// </para>
    /// </summary>
    System.String EncouragementTextMessagingString { get; set; }

    /// <summary>
    /// Assessment Personal Needs Profile Activate by Default
    /// <para>
    /// Determines if the alternative accessible content is rendered as the default content for the learner.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20008">Assessment Personal Needs Profile Activate by Default</a>
    /// </para>
    /// </summary>
    Boolean? MaskingActivateByDefaultIndicator { get; set; }

    /// <summary>
    /// Assessment Personal Needs Profile Assigned Support
    /// <para>
    /// Defines whether or not the individual needs the kind of support defined by the entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20007">Assessment Personal Needs Profile Assigned Support</a>
    /// </para>
    /// </summary>
    Boolean? MaskingAssignedSupportIndicator { get; set; }

    /// <summary>
    /// Assessment Need Masking Type
    /// <para>
    /// Specifies as part of an Assessment Personal Needs Profile the type of masks the user is able to create  to cover portions of the question until needed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20051">Assessment Need Masking Type</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentNeedMaskingTypeId { get; set; }

    #endregion
}
