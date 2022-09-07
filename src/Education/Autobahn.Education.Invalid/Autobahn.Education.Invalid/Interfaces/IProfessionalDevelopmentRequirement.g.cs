//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IProfessionalDevelopmentRequirement.g.cs
//***************************************************************************

/// <summary>
/// The IProfessionalDevelopmentRequirement file
/// </summary>
public partial interface IProfessionalDevelopmentRequirement
{
    #region "IProfessionalDevelopmentRequirement Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    Guid? CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Required Training Clock Hours
    /// <para>
    /// Number of clock hours of training required for providers to meet requirements of the state.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19803">Required Training Clock Hours</a>
    /// </para>
    /// </summary>
    Decimal? RequiredTrainingClockHours { get; set; }

    #endregion
}
