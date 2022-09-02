//***************************************************************************
//* DomainName: Common Models
//* FileName:   RecordStatusHistoryEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRecordStatusHistory file
/// </summary>
[Table("RecordStatusHistory", Schema = "Common")]
public partial class RecordStatusHistoryEntity : EntityBase, IRecordStatusHistory
{
    #region "IRecordStatusHistory Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRecord"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The Record property is obsolete and will be removed in a later version")]
    [ForeignKey("Record")]
    public Guid RecordId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RecordPkcolumn { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRecordStatusCreatorOrganization"/> model
    /// </summary>
    [Obsolete("The RecordStatusCreatorOrganization property is obsolete and will be removed in a later version")]
    [ForeignKey("RecordStatusCreatorOrganization")]
    public Guid? RecordStatusCreatorOrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRecordStatusCreatorPerson"/> model
    /// </summary>
    [Obsolete("The RecordStatusCreatorPerson property is obsolete and will be removed in a later version")]
    [ForeignKey("RecordStatusCreatorPerson")]
    public Guid? RecordStatusCreatorPersonId { get; set; }

    /// <summary>
    /// Record Status Date
    /// <para>
    /// The date the record was marked with the Record Status Type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20957">Record Status Date</a>
    /// </para>
    /// </summary>
    [Comment("The date the record was marked with the Record Status Type.")]
    public DateTime? RecordStatusDate { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RecordTable { get; set; }

    /// <summary>
    /// Record Status Creator Entity
    /// <para>
    /// The type of entity that created or indicated the Record Status Type
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20956">Record Status Creator Entity</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefRecordStatusCreatorEntity")]
    [Comment("The type of entity that created or indicated the Record Status Type")]
    public Guid? RefRecordStatusCreatorEntityId { get; set; }

    /// <summary>
    /// Record Status Type
    /// <para>
    /// A process indicator of the level of stability, quality, and/or preparedness of the record.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20958">Record Status Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefRecordStatusType")]
    [Comment("A process indicator of the level of stability, quality, and/or preparedness of the record.")]
    public Guid RefRecordStatusTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// A process indicator of the level of stability, quality, and/or preparedness of the record.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20958">Record Status Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefRecordStatusTypeEntity RefRecordStatusTypeEntity { get; set; }

    /// <summary>
    /// The type of entity that created or indicated the Record Status Type
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20956">Record Status Creator Entity</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefRecordStatusCreatorEntityEntity RefRecordStatusCreatorEntityEntity { get; set; }

    #endregion
}
