//***************************************************************************
//* DomainName: Common Models
//* FileName:   RecordStatusEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRecordStatus file
/// </summary>
public partial class RecordStatusModel : AutobahnBaseModel, IRecordStatus
{
    #region "IRecordStatus Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRecordStatusCreatorOrganization"/> model
    /// </summary>
    public Guid? RecordStatusCreatorOrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRecordStatusCreatorPerson"/> model
    /// </summary>
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
    public DateTime? RecordStatusDate { get; set; }

    /// <summary>
    /// Record Status Creator Entity
    /// <para>
    /// The type of entity that created or indicated the Record Status Type
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20956">Record Status Creator Entity</a>
    /// </para>
    /// </summary>
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
    public Guid RefRecordStatusTypeId { get; set; }

    #endregion
}
