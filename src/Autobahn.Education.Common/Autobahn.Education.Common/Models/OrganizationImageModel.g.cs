//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationImageEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationImage file
/// </summary>
public partial class OrganizationImageModel : AutobahnBaseModel, IOrganizationImage
{
    #region "IOrganizationImage Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    public System.String Url { get; set; }

    #endregion
}
