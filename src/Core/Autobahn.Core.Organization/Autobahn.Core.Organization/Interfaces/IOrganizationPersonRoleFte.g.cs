//***************************************************************************
//* DomainName: Organization Models
//* FileName:   IOrganizationPersonRoleFte.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPersonRoleFte file
/// </summary>
public partial interface IOrganizationPersonRoleFte
{
    #region "IOrganizationPersonRoleFte Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.Decimal FullTimeEquivalency { get; set; }

    System.Int32 OrganizationPersonRoleFteid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    #endregion
}
