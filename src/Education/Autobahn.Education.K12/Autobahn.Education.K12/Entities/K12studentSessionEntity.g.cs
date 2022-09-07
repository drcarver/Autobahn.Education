//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentSessionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentSession file
/// </summary>
[Table("K12studentSession", Schema = "K12")]
public partial class K12studentSessionEntity : EntityBase, IK12studentSession
{
    #region "IK12studentSession Properties"
    public Decimal? GradePointAverageGivenSession { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    [ForeignKey("OrganizationCalendarSession")]
    public Guid? OrganizationCalendarSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> implementation
    /// <remarks>
    /// This entity is in the K12 domain
    /// </remarks>
    /// </summary>
    public virtual OrganizationCalendarSessionEntity? OrganizationCalendarSessionEntity { get; set; }

    #endregion
}
