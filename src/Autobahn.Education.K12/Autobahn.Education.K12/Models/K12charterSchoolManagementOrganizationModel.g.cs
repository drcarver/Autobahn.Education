//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12charterSchoolManagementOrganizationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12charterSchoolManagementOrganization file
/// </summary>
public partial class K12charterSchoolManagementOrganizationModel : AutobahnBaseModel, IK12charterSchoolManagementOrganization
{
    #region "IK12charterSchoolManagementOrganization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterSchoolManagementOrganizationType"/> model
    /// </summary>
    public Guid? RefCharterSchoolManagementOrganizationTypeId { get; set; }

    #endregion
}
