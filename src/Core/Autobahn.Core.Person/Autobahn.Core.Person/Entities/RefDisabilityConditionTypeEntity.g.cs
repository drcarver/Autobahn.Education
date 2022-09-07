//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefDisabilityConditionTypeEntity.g.cs
//* Name:       Disability Condition Type
//* Definition: Codes identifying the set of disability conditions.
//***************************************************************************

/// <summary>
/// Disability Condition Type <see cref="RefDisabilityConditionType"/>
/// <para>
/// Codes identifying the set of disability conditions.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20286">Disability Condition Type</a>
/// </para>
/// </summary>
[Table("RefDisabilityConditionType", Schema = "Person")]
[Comment("Codes identifying the set of disability conditions.")]
public partial class RefDisabilityConditionTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
