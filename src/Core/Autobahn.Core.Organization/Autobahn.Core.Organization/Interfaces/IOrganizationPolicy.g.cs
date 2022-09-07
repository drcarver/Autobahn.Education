//***************************************************************************
//* DomainName: Organization Models
//* FileName:   IOrganizationPolicy.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationPolicy file
/// </summary>
public partial interface IOrganizationPolicy
{
    #region "IOrganizationPolicy Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Personnel Policy Type
    /// <para>
    /// Policies related to personnel in the organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19842">Personnel Policy Type</a>
    /// </para>
    /// </summary>
    System.String PolicyType { get; set; }

    System.String Value { get; set; }

    #endregion
}
