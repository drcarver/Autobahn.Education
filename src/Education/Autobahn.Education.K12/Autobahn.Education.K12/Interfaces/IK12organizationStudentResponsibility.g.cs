//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12organizationStudentResponsibility.g.cs
//***************************************************************************

/// <summary>
/// The IK12organizationStudentResponsibility file
/// </summary>
public partial interface IK12organizationStudentResponsibility
{
    #region "IK12organizationStudentResponsibility Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12responsibilityType"/> model
    /// </summary>
    Guid RefK12responsibilityTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStudentSchoolAffiliationStateDefinedStatus"/> model
    /// </summary>
    Guid? RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

    #endregion
}
