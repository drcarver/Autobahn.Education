//***************************************************************************
//* DomainName: Person Models
//* FileName:   OrganizationPersonRoleFteEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPersonRoleFte file
/// </summary>
public partial class OrganizationPersonRoleFteModel : AutobahnBaseModel, IOrganizationPersonRoleFte
{
    #region "IOrganizationPersonRoleFte Properties"
    public System.Decimal FullTimeEquivalency { get; set; }

    public System.Int32 OrganizationPersonRoleFteid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    #endregion
}
