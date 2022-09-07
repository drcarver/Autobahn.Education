//***************************************************************************
//* DomainName: Organization Models
//* FileName:   IOrganizationImage.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationImage file
/// </summary>
public partial interface IOrganizationImage
{
    #region "IOrganizationImage Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    System.String Url { get; set; }

    #endregion
}
