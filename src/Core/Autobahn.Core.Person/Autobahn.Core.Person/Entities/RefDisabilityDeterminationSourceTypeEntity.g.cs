//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefDisabilityDeterminationSourceTypeEntity.g.cs
//* Name:       Disability Determination Source Type
//* Definition: Codes identifying the set of disability determination sources.
//***************************************************************************

/// <summary>
/// Disability Determination Source Type <see cref="RefDisabilityDeterminationSourceType"/>
/// <para>
/// Codes identifying the set of disability determination sources.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20287">Disability Determination Source Type</a>
/// </para>
/// </summary>
[Table("RefDisabilityDeterminationSourceType", Schema = "Person")]
[Comment("Codes identifying the set of disability determination sources.")]
public partial class RefDisabilityDeterminationSourceTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
