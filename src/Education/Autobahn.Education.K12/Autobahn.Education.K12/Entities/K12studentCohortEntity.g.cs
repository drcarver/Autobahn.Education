//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentCohortEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentCohort file
/// </summary>
[Table("K12studentCohort", Schema = "K12")]
public partial class K12studentCohortEntity : EntityBase, IK12studentCohort
{
    #region "IK12studentCohort Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CohortDescription { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CohortGraduationYear { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CohortYear { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String GraduationRateSurveyCohortYear { get; set; }

    public Boolean? GraduationRateSurveyIndicator { get; set; }

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
