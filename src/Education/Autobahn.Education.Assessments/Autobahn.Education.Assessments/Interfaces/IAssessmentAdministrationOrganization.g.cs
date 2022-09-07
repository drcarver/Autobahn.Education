//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentAdministrationOrganization.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAdministrationOrganization file
/// </summary>
public partial interface IAssessmentAdministrationOrganization
{
    #region "IAssessmentAdministrationOrganization Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
    /// </summary>
    Guid AssessmentAdministrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    #endregion
}
