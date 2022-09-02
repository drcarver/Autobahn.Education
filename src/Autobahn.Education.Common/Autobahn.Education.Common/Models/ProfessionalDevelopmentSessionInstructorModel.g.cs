//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentSessionInstructorEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProfessionalDevelopmentSessionInstructor file
/// </summary>
public partial class ProfessionalDevelopmentSessionInstructorModel : AutobahnBaseModel, IProfessionalDevelopmentSessionInstructor
{
    #region "IProfessionalDevelopmentSessionInstructor Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentSession"/> model
    /// </summary>
    public Guid ProfessionalDevelopmentSessionId { get; set; }

    #endregion
}
