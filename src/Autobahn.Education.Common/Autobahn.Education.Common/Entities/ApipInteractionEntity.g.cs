//***************************************************************************
//* DomainName: Common Models
//* FileName:   ApipInteractionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IApipInteraction file
/// </summary>
[Table("ApipInteraction", Schema = "Common")]
public partial class ApipInteractionEntity : EntityBase, IApipInteraction
{
    #region "IApipInteraction Properties"
    public Decimal? ApipinteractionSequenceNumber { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemApip"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentItemApip")]
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
    [ForeignKey("RefApipInteractionType")]
    [Comment("The drawing interaction allows the candidate to use a common set of drawing tools to modify a given graphical image (the canvas). It must be bound to a response variable with base-type file and single cardinality. The result is a file in the same format as the original image. The XML from the IMS Global APIP Specification would be included.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.")]
    public System.String Xml { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItemApip"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentItemApipEntity AssessmentItemApipEntity { get; set; }

    /// <summary>
    /// The drawing interaction allows the candidate to use a common set of drawing tools to modify a given graphical image (the canvas). It must be bound to a response variable with base-type file and single cardinality. The result is a file in the same format as the original image. The XML from the IMS Global APIP Specification would be included.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20080">Assessment Item Body Drawing Interaction XML</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefApipInteractionTypeEntity RefApipInteractionTypeEntity { get; set; }

    #endregion
}
