//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12charterSchoolAuthorizerAgencyEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12charterSchoolAuthorizerAgency file
/// </summary>
public partial class K12charterSchoolAuthorizerAgencyModel : AutobahnBaseModel, IK12charterSchoolAuthorizerAgency
{
    #region "IK12charterSchoolAuthorizerAgency Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterSchoolAuthorizerType"/> model
    /// </summary>
    public Guid RefCharterSchoolAuthorizerTypeId { get; set; }

    #endregion
}
