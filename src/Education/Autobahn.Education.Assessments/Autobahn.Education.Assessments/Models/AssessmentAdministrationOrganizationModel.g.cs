//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministrationOrganizationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAdministrationOrganization file
/// </summary>
public partial class AssessmentAdministrationOrganizationModel : AutobahnBaseModel, IAssessmentAdministrationOrganization
{
    #region "IAssessmentAdministrationOrganization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
    /// </summary>
    public Guid AssessmentAdministrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    #endregion
}
