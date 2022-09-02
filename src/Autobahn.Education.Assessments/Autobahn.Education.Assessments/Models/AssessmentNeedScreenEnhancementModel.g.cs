//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedScreenEnhancementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentNeedScreenEnhancement file
/// </summary>
public partial class AssessmentNeedScreenEnhancementModel : AutobahnBaseModel, IAssessmentNeedScreenEnhancement
{
    #region "IAssessmentNeedScreenEnhancement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> model
    /// </summary>
    public Guid AssessmentPersonalNeedsProfileDisplayId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileScreenEnhancement"/> model
    /// </summary>
    public Guid? AssessmentPersonalNeedsProfileScreenEnhancementId { get; set; }

    /// <summary>
    /// Assessment Need Foreground Color
    /// <para>
    /// This is the preferred Foreground color for screen enhancement defined as part of an Assessment Personal Needs Profile.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20058">Assessment Need Foreground Color</a>
    /// </para>
    /// </summary>
    public System.String ForegroundColor { get; set; }

    /// <summary>
    /// Assessment Need Invert Color Choice
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the Access for All (AfA) preference to invert the foreground and background Colors.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20033">Assessment Need Invert Color Choice</a>
    /// </para>
    /// </summary>
    public Boolean? InvertColorChoice { get; set; }

    /// <summary>
    /// Assessment Need Magnification
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the preferred magnification of the screen as a factor of a screen's original size.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20034">Assessment Need Magnification</a>
    /// </para>
    /// </summary>
    public Decimal? Magnification { get; set; }

    #endregion
}
