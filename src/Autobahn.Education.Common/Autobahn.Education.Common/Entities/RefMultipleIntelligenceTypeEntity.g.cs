//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefMultipleIntelligenceTypeEntity.g.cs
//* Name:       Competency Definition Multiple Intelligence
//* Definition: Classification of the Competency Definition using intelligences defined for Howard Earl Gardner's Theory of Multiple Intelligences.
//***************************************************************************

/// <summary>
/// Competency Definition Multiple Intelligence <see cref="RefMultipleIntelligenceType"/>
/// <para>
/// Classification of the Competency Definition using intelligences defined for Howard Earl Gardner's Theory of Multiple Intelligences.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19876">Competency Definition Multiple Intelligence</a>
/// </para>
/// </summary>
[Table("RefMultipleIntelligenceType", Schema = "Common")]
[Comment("Classification of the Competency Definition using intelligences defined for Howard Earl Gardner's Theory of Multiple Intelligences.")]
public partial class RefMultipleIntelligenceTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
