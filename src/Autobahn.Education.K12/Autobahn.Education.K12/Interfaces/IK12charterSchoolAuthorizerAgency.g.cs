//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12charterSchoolAuthorizerAgency.g.cs
//***************************************************************************

/// <summary>
/// The IK12charterSchoolAuthorizerAgency file
/// </summary>
public partial interface IK12charterSchoolAuthorizerAgency
{
    #region "IK12charterSchoolAuthorizerAgency Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterSchoolAuthorizerType"/> model
    /// </summary>
    Guid RefCharterSchoolAuthorizerTypeId { get; set; }

    #endregion
}
