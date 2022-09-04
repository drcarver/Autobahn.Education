//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProfessionalDevelopmentSessionInstructorEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProfessionalDevelopmentSessionInstructor file
/// </summary>
[Table("ProfessionalDevelopmentSessionInstructor", Schema = "Invalid")]
public partial class ProfessionalDevelopmentSessionInstructorEntity : EntityBase, IProfessionalDevelopmentSessionInstructor
{
    #region "IProfessionalDevelopmentSessionInstructor Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentSession"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ProfessionalDevelopmentSession")]
    public Guid ProfessionalDevelopmentSessionId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentSession"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual ProfessionalDevelopmentSessionEntity ProfessionalDevelopmentSessionEntity { get; set; }

    #endregion
}
