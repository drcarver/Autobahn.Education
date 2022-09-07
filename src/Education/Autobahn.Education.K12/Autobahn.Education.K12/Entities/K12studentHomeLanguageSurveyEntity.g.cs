//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentHomeLanguageSurveyEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentHomeLanguageSurvey file
/// </summary>
[Table("K12studentHomeLanguageSurvey", Schema = "K12")]
public partial class K12studentHomeLanguageSurveyEntity : EntityBase, IK12studentHomeLanguageSurvey
{
    #region "IK12studentHomeLanguageSurvey Properties"
    public DateTime? HomeLanguageSurveyAdministrationDate { get; set; }

    public Boolean? HomeLanguageSurveyAdministrationIndicator { get; set; }

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
