//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefParticipationTypeEntity.g.cs
//* Name:       GED Preparation Program Participation Status
//* Definition: An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
//***************************************************************************

/// <summary>
/// GED Preparation Program Participation Status <see cref="RefParticipationType"/>
/// <para>
/// An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19120">GED Preparation Program Participation Status</a>
/// </para>
/// </summary>
[Table("RefParticipationType", Schema = "Person")]
[Comment("An indication that a student aged 16-19 participates in a General Educational Development (GED) preparation program.")]
public partial class RefParticipationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefParticipationType Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [ForeignKey("Organization")]
    public Guid? OrganizationId { get; set; }

    #endregion
}
