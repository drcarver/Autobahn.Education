//***************************************************************************
//* DomainName: Common Models
//* FileName:   IOrganizationLocation.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationLocation file
/// </summary>
public partial interface IOrganizationLocation
{
    #region "IOrganizationLocation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> model
    /// </summary>
    Guid LocationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Address Type for Organization
    /// <para>
    /// The type of address listed for an organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19644">Address Type for Organization</a>
    /// </para>
    /// </summary>
    Guid? RefOrganizationLocationTypeId { get; set; }

    #endregion
}
