//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefLearningResourceAuthorTypeEntity.g.cs
//* Name:       Learning Resource Author Type
//* Definition: The type of entity, organization or person, that authored the learning resource.
//***************************************************************************

/// <summary>
/// Learning Resource Author Type <see cref="RefLearningResourceAuthorType"/>
/// <para>
/// The type of entity, organization or person, that authored the learning resource.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20540">Learning Resource Author Type</a>
/// </para>
/// </summary>
[Table("RefLearningResourceAuthorType", Schema = "Common")]
[Comment("The type of entity, organization or person, that authored the learning resource.")]
public partial class RefLearningResourceAuthorTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
