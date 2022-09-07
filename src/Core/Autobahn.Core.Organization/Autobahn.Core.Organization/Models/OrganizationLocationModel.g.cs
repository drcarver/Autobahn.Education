//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationLocationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationLocation file
/// </summary>
public partial class OrganizationLocationModel : AutobahnBaseModel, IOrganizationLocation
{
    #region "IOrganizationLocation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> model
    /// </summary>
    public Guid LocationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Address Type for Organization
    /// <para>
    /// The type of address listed for an organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19644">Address Type for Organization</a>
    /// </para>
    /// </summary>
    public Guid? RefOrganizationLocationTypeId { get; set; }

    #endregion
}
