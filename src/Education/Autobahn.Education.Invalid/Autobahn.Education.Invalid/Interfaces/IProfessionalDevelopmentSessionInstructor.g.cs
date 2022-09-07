//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IProfessionalDevelopmentSessionInstructor.g.cs
//***************************************************************************

/// <summary>
/// The IProfessionalDevelopmentSessionInstructor file
/// </summary>
public partial interface IProfessionalDevelopmentSessionInstructor
{
    #region "IProfessionalDevelopmentSessionInstructor Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentSession"/> model
    /// </summary>
    Guid ProfessionalDevelopmentSessionId { get; set; }

    #endregion
}
