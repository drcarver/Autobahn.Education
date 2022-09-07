//***************************************************************************
//* DomainName: Organization Models
//* FileName:   IOrganizationRelationship.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationRelationship file
/// </summary>
public partial interface IOrganizationRelationship
{
    #region "IOrganizationRelationship Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IParentOrganization"/> model
    /// </summary>
    Guid ParentOrganizationId { get; set; }

    /// <summary>
    /// Organization Relationship Type
    /// <para>
    /// The nature of one organization's relationship to another.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20886">Organization Relationship Type</a>
    /// </para>
    /// </summary>
    Guid? RefOrganizationRelationshipId { get; set; }

    #endregion
}
