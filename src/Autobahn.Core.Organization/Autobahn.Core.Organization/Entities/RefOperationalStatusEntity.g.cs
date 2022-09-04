//***************************************************************************
//* DomainName: Organization Models
//* FileName:   RefOperationalStatusEntity.g.cs
//* Name:       Local Education Agency Operational Status
//* Definition: The classification of the operational condition of a local education agency (LEA) at the start of the school year.
//***************************************************************************

/// <summary>
/// Local Education Agency Operational Status <see cref="RefOperationalStatus"/>
/// <para>
/// The classification of the operational condition of a local education agency (LEA) at the start of the school year.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19174">Local Education Agency Operational Status</a>
/// </para>
/// </summary>
[Table("RefOperationalStatus", Schema = "Autobahn.Core.Organization")]
[Comment("The classification of the operational condition of a local education agency (LEA) at the start of the school year.")]
public partial class RefOperationalStatusEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefOperationalStatus Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOperationalStatusType"/> model
    /// </summary>
    [ForeignKey("RefOperationalStatusType")]
    public Guid? RefOperationalStatusTypeId { get; set; }

    #endregion
}
