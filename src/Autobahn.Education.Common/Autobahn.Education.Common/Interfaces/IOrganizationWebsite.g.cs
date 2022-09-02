//***************************************************************************
//* DomainName: Common Models
//* FileName:   IOrganizationWebsite.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationWebsite file
/// </summary>
public partial interface IOrganizationWebsite
{
    #region "IOrganizationWebsite Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Web Site Address
    /// <para>
    /// The Uniform Resource Locator (URL) for the unique address of a Web page.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19300">Web Site Address</a>
    /// </para>
    /// </summary>
    System.String Website { get; set; }

    #endregion
}
