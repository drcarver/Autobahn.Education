//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedBrailleEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentNeedBraille file
/// </summary>
public partial class AssessmentNeedBrailleModel : AutobahnBaseModel, IAssessmentNeedBraille
{
    #region "IAssessmentNeedBraille Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfileDisplay"/> model
    /// </summary>
    public Guid? AssessmentPersonalNeedsProfileDisplayId { get; set; }

    /// <summary>
    /// Assessment Need Braille Dot Pressure
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the resistance pressure of Braille display pins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20040">Assessment Need Braille Dot Pressure</a>
    /// </para>
    /// </summary>
    public Decimal? BrailleDotPressure { get; set; }

    /// <summary>
    /// Assessment Need Number of Braille Cells
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the number of active Braille cells in a Braille display.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20037">Assessment Need Number of Braille Cells</a>
    /// </para>
    /// </summary>
    public Int32? NumberOfBrailleCells { get; set; }

    /// <summary>
    /// Assessment Need Braille Grade Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the grade of Braille to use when using a Braille display.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20035">Assessment Need Braille Grade Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentNeedBrailleGradeTypeId { get; set; }

    /// <summary>
    /// Assessment Need Braille Mark Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile what textual properties to mark when using a Braille display.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20038">Assessment Need Braille Mark Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentNeedBrailleMarkTypeId { get; set; }

    /// <summary>
    /// Assessment Need Braille Status Cell Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the preferred presence or location of a Braille display status cell.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20041">Assessment Need Braille Status Cell Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentNeedBrailleStatusCellTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentNeedNumberOfBrailleDot"/> model
    /// </summary>
    public Guid? RefAssessmentNeedNumberOfBrailleDotId { get; set; }

    /// <summary>
    /// Assessment Need Usage Type
    /// <para>
    /// Defines as part of an Assessment Personal Needs Profile the rating for the collection of Access for All (AfA) needs and preferences.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20028">Assessment Need Usage Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAssessmentNeedUsageTypeId { get; set; }

    #endregion
}
