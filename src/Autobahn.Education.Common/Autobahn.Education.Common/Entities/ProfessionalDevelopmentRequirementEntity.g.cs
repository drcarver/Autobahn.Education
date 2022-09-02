//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentRequirementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProfessionalDevelopmentRequirement file
/// </summary>
[Table("ProfessionalDevelopmentRequirement", Schema = "Common")]
public partial class ProfessionalDevelopmentRequirementEntity : EntityBase, IProfessionalDevelopmentRequirement
{
    #region "IProfessionalDevelopmentRequirement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    [ForeignKey("CompetencySet")]
    public Guid? CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
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
    [Comment("Number of clock hours of training required for providers to meet requirements of the state.")]
    public Decimal? RequiredTrainingClockHours { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual CompetencySetEntity CompetencySetEntity { get; set; }

    #endregion
}
