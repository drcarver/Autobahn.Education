//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentNeedApipContent.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentNeedApipContent file
/// </summary>
public partial interface IAssessmentNeedApipContent
{
    #region "IAssessmentNeedApipContent Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Assessment Need Directions Only
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile whether or not the verbal alternative content presentation should be applied to directive content only.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20050">Assessment Need Directions Only</a>
    /// </para>
    /// </summary>
    Boolean? AssessmentNeedDirectionsOnlyIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileContent"/> model
    /// </summary>
    Guid AssessmentPersonalNeedsProfileContentId { get; set; }

    /// <summary>
    /// Assessment Need Item Translation Display Language Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20042">Assessment Need Item Translation Display Language Type</a>
    /// </para>
    /// </summary>
    Guid? ItemTranslationDisplayLanguageTypeId { get; set; }

    /// <summary>
    /// Assessment Need Keyword Translation Language Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the default language for the keyword translation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20043">Assessment Need Keyword Translation Language Type</a>
    /// </para>
    /// </summary>
    Guid? KeywordTranslationLanguageTypeId { get; set; }

    /// <summary>
    /// Assessment Need Read at Start Preference
    /// <para>
    /// Used as part of an Assessment Personal Needs Profile to define if the spoken play-back should commence from the start of a recording or not.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20048">Assessment Need Read at Start Preference</a>
    /// </para>
    /// </summary>
    Boolean? ReadAtStartPreferenceIndicator { get; set; }

    /// <summary>
    /// Assessment Need Alternative Representation Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the default presentation mode of the associated Alternative Representations accessibility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20045">Assessment Need Alternative Representation Type</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentNeedAlternativeRepresentationTypeId { get; set; }

    /// <summary>
    /// Assessment Need Signing Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the type of signing preferred by the user.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20044">Assessment Need Signing Type</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentNeedSigningTypeId { get; set; }

    /// <summary>
    /// Assessment Need Spoken Source Preference Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the preferred spoken audio form.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20046">Assessment Need Spoken Source Preference Type</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentNeedSpokenSourcePreferenceTypeId { get; set; }

    /// <summary>
    /// Assessment Need User Spoken Preference Type
    /// <para>
    /// Used as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20049">Assessment Need User Spoken Preference Type</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentNeedUserSpokenPreferenceTypeId { get; set; }

    #endregion
}
