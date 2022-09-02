//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentNeedScreenEnhancement.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentNeedScreenEnhancement file
/// </summary>
public partial interface IAssessmentNeedScreenEnhancement
{
    #region "IAssessmentNeedScreenEnhancement Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> model
    /// </summary>
    Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileScreenEnhancement"/> model
    /// </summary>
    Guid? AssessmentPersonalNeedsProfileScreenEnhancementId { get; set; }

    /// <summary>
    /// Assessment Need Foreground Color
    /// <para>
    /// This is the preferred Foreground color for screen enhancement defined as part of an Assessment Personal Needs Profile.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20058">Assessment Need Foreground Color</a>
    /// </para>
    /// </summary>
    System.String ForegroundColor { get; set; }

    /// <summary>
    /// Assessment Need Invert Color Choice
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20033">Assessment Need Invert Color Choice</a>
    /// </para>
    /// </summary>
    Boolean? InvertColorChoice { get; set; }

    /// <summary>
    /// Assessment Need Magnification
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the preferred magnification of the screen as a factor of a screen's original size.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20034">Assessment Need Magnification</a>
    /// </para>
    /// </summary>
    Decimal? Magnification { get; set; }

    #endregion
}
