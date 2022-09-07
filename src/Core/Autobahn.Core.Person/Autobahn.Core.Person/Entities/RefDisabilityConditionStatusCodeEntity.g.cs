//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefDisabilityConditionStatusCodeEntity.g.cs
//* Name:       Disability Condition Status Type
//* Definition: A code indicating the disability condition status.
//***************************************************************************

/// <summary>
/// Disability Condition Status Type <see cref="RefDisabilityConditionStatusCode"/>
/// <para>
/// A code indicating the disability condition status.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20285">Disability Condition Status Type</a>
/// </para>
/// </summary>
[Table("RefDisabilityConditionStatusCode", Schema = "Person")]
[Comment("A code indicating the disability condition status.")]
public partial class RefDisabilityConditionStatusCodeEntity : ReferenceBaseEntity, IReferenceBase
{
}
