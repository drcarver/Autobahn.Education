//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentCohortEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentCohort file
/// </summary>
[Table("PsStudentCohort", Schema = "Postsecondary")]
public partial class PsStudentCohortEntity : EntityBase, IPsStudentCohort
{
    #region "IPsStudentCohort Properties"
    /// <summary>
    /// Cohort Graduation Year
    /// <para>
    /// The year the cohort is expected to graduate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19577">Cohort Graduation Year</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The year the cohort is expected to graduate.")]
    public System.String CohortGraduationYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
