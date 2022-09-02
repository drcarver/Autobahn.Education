//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12organizationStudentResponsibilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12organizationStudentResponsibility file
/// </summary>
public partial class K12organizationStudentResponsibilityModel : AutobahnBaseModel, IK12organizationStudentResponsibility
{
    #region "IK12organizationStudentResponsibility Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12responsibilityType"/> model
    /// </summary>
    public Guid RefK12responsibilityTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStudentSchoolAffiliationStateDefinedStatus"/> model
    /// </summary>
    public Guid? RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

    #endregion
}
