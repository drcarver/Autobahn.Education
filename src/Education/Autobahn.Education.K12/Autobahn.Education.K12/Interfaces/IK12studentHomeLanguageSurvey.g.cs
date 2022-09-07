//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12studentHomeLanguageSurvey.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentHomeLanguageSurvey file
/// </summary>
public partial interface IK12studentHomeLanguageSurvey
{
    #region "IK12studentHomeLanguageSurvey Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    DateTime? HomeLanguageSurveyAdministrationDate { get; set; }

    Boolean? HomeLanguageSurveyAdministrationIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    #endregion
}
