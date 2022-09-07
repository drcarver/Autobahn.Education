//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentHomeLanguageSurveyEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentHomeLanguageSurvey file
/// </summary>
public partial class K12studentHomeLanguageSurveyModel : AutobahnBaseModel, IK12studentHomeLanguageSurvey
{
    #region "IK12studentHomeLanguageSurvey Properties"
    public DateTime? HomeLanguageSurveyAdministrationDate { get; set; }

    public Boolean? HomeLanguageSurveyAdministrationIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion
}
