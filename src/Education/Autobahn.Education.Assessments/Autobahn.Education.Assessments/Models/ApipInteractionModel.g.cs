//***************************************************************************
//* DomainName: Assessments
//* FileName:   ApipInteractionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IApipInteraction file
/// </summary>
public partial class ApipInteractionModel : AutobahnBaseModel, IApipInteraction
{
    #region "IApipInteraction Properties"
    public Decimal? ApipinteractionSequenceNumber { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemApip"/> model
    /// </summary>
    public Guid AssessmentItemApipId { get; set; }

    /// <summary>
    /// Assessment Item Body Drawing Interaction XML
    /// <para>
    /// The drawing interaction allows the candidate to use a common set of drawing tools to modify a given graphical image (the canvas). It must be bound to a response variable with base-type file and single cardinality. The result is a file in the same format as the original image. The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20080">Assessment Item Body Drawing Interaction XML</a>
    /// </para>
    /// </summary>
    public Guid? RefApipInteractionTypeId { get; set; }

    public Int32? SequenceNumber { get; set; }

    /// <summary>
    /// Assessment Item Body Custom Interaction XML
    /// <para>
    /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20079">Assessment Item Body Custom Interaction XML</a>
    /// </para>
    /// </summary>
    public System.String Xml { get; set; }

    #endregion
}
