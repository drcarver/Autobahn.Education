//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12charterSchoolManagementOrganization.g.cs
//***************************************************************************

/// <summary>
/// The IK12charterSchoolManagementOrganization file
/// </summary>
public partial interface IK12charterSchoolManagementOrganization
{
    #region "IK12charterSchoolManagementOrganization Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterSchoolManagementOrganizationType"/> model
    /// </summary>
    Guid? RefCharterSchoolManagementOrganizationTypeId { get; set; }

    #endregion
}
