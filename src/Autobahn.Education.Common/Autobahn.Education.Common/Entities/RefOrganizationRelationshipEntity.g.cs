//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefOrganizationRelationshipEntity.g.cs
//* Name:       Organization Relationship Type
//* Definition: The nature of one organization's relationship to another.
//***************************************************************************

/// <summary>
/// Organization Relationship Type <see cref="RefOrganizationRelationship"/>
/// <para>
/// The nature of one organization's relationship to another.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20886">Organization Relationship Type</a>
/// </para>
/// </summary>
[Table("RefOrganizationRelationship", Schema = "Common")]
[Comment("The nature of one organization's relationship to another.")]
public partial class RefOrganizationRelationshipEntity : ReferenceBaseEntity, IReferenceBase
{
}
