//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationRelationshipEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationRelationship file
/// </summary>
public partial class OrganizationRelationshipModel : AutobahnBaseModel, IOrganizationRelationship
{
    #region "IOrganizationRelationship Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IParentOrganization"/> model
    /// </summary>
    public Guid ParentOrganizationId { get; set; }

    /// <summary>
    /// Organization Relationship Type
    /// <para>
    /// The nature of one organization's relationship to another.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20886">Organization Relationship Type</a>
    /// </para>
    /// </summary>
    public Guid? RefOrganizationRelationshipId { get; set; }

    #endregion
}
