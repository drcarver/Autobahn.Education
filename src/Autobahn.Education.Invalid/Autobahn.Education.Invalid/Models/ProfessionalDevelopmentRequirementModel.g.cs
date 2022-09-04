//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProfessionalDevelopmentRequirementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProfessionalDevelopmentRequirement file
/// </summary>
public partial class ProfessionalDevelopmentRequirementModel : AutobahnBaseModel, IProfessionalDevelopmentRequirement
{
    #region "IProfessionalDevelopmentRequirement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    public Guid? CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Required Training Clock Hours
    /// <para>
    /// Number of clock hours of training required for providers to meet requirements of the state.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19803">Required Training Clock Hours</a>
    /// </para>
    /// </summary>
    public Decimal? RequiredTrainingClockHours { get; set; }

    #endregion
}
