//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemResponseTheoryEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemResponseTheory file
/// </summary>
public partial class AssessmentItemResponseTheoryModel : AutobahnBaseModel, IAssessmentItemResponseTheory
{
    #region "IAssessmentItemResponseTheory Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    public Guid AssessmentItemId { get; set; }

    public Int32? Difvalue { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Kappa Value
    /// <para>
    /// The measure used to represent the degree of agreement among raters.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20231">Assessment Item Response Theory Kappa Value</a>
    /// </para>
    /// </summary>
    public Int32? KappaValue { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Parameter A
    /// <para>
    /// The Item Response Theory value representing the discrimination of the item. The a parameter is found by taking the slope of the line tangent to the item characteristic curve at the inflection point, B. The parameter is the steepness of the curve at its steepest point.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20217">Assessment Item Response Theory Parameter A</a>
    /// </para>
    /// </summary>
    public Int32? ParameterA { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Parameter B
    /// <para>
    /// The Item Response Theory value representing the difficulty of the item.   It is the Theta value for the location of the inflection point of the item characteristic curve.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20218">Assessment Item Response Theory Parameter B</a>
    /// </para>
    /// </summary>
    public Int32? ParameterB { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Parameter C
    /// <para>
    /// The Item Response Theory value for multiple choice items representing the guessing of the item. The c parameter is a lower asymptote. It is the low point of the curve as it moves to negative infinity on the horizontal axis. You can think of c as the probability that a chicken would get the item right.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20220">Assessment Item Response Theory Parameter C</a>
    /// </para>
    /// </summary>
    public Int32? ParameterC { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Parameter D1
    /// <para>
    /// For   polytomous assessment items with more than two possible responses, this is the item response theory value representing the threshold between the first and second item characteristic functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20221">Assessment Item Response Theory Parameter D1</a>
    /// </para>
    /// </summary>
    public Int32? ParameterD1 { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Parameter D2
    /// <para>
    /// For   polytomous assessment items with more than two possible responses, this is the item response theory value representing the threshold between the second and third item characteristic functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20222">Assessment Item Response Theory Parameter D2</a>
    /// </para>
    /// </summary>
    public Int32? ParameterD2 { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Parameter D3
    /// <para>
    /// For   polytomous assessment items with more than three possible responses, this is the item response theory value representing the threshold between the third and fourth item characteristic functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20223">Assessment Item Response Theory Parameter D3</a>
    /// </para>
    /// </summary>
    public Int32? ParameterD3 { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Parameter D4
    /// <para>
    /// For   polytomous assessment items with more than four possible responses, this is the item response theory value representing the threshold between the fourth and fifth item characteristic functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20224">Assessment Item Response Theory Parameter D4</a>
    /// </para>
    /// </summary>
    public Int32? ParameterD4 { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Parameter D5
    /// <para>
    /// For   polytomous assessment items with more than five possible responses, this is the item response theory value representing the threshold between the fifth and sixth item characteristic functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20225">Assessment Item Response Theory Parameter D5</a>
    /// </para>
    /// </summary>
    public Int32? ParameterD5 { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Parameter D6
    /// <para>
    /// For   polytomous assessment items with more than six possible responses, this is the item response theory value representing the threshold between the sixth and seventh item characteristic functions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20226">Assessment Item Response Theory Parameter D6</a>
    /// </para>
    /// </summary>
    public Int32? ParameterD6 { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Point Biserial Correlation Value
    /// <para>
    /// The correlation between correct answers on this item and total correct answers on the test during a previous administration.�
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20228">Assessment Item Response Theory Point Biserial Correlation Value</a>
    /// </para>
    /// </summary>
    public Int32? PointBiserialCorrelationValue { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Parameter Difficulty Category
    /// <para>
    /// A category for the difficulty of the item based on the Item Response Theory value.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20219">Assessment Item Response Theory Parameter Difficulty Category</a>
    /// </para>
    /// </summary>
    public Guid? RefItemResponseTheoryDifficultyCategoryId { get; set; }

    /// <summary>
    /// Assessment Item Response Theory Kappa Algorithm
    /// <para>
    /// The algorithm used to derive the Assessment Item Kappa Value
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20232">Assessment Item Response Theory Kappa Algorithm</a>
    /// </para>
    /// </summary>
    public Guid? RefItemResponseTheoryKappaAlgorithmId { get; set; }

    #endregion
}
