//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefPersonRelationshipTypeEntity.g.cs
//* Name:       Person Relationship Type
//* Definition: The nature of a person's relationship to another person.
//***************************************************************************

/// <summary>
/// Person Relationship Type <see cref="RefPersonRelationshipType"/>
/// <para>
/// The nature of a person's relationship to another person.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19415">Person Relationship Type</a>
/// </para>
/// </summary>
[Table("RefPersonRelationshipType", Schema = "Common")]
[Comment("The nature of a person's relationship to another person.")]
public partial class RefPersonRelationshipTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
