//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefDisabilityTypeEntity.g.cs
//* Name:       Primary Disability Type
//* Definition: The major or overriding disability condition that best describes a person's impairment.
//***************************************************************************

/// <summary>
/// Primary Disability Type <see cref="RefDisabilityType"/>
/// <para>
/// The major or overriding disability condition that best describes a person's impairment.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19218">Primary Disability Type</a>
/// </para>
/// </summary>
[Table("RefDisabilityType", Schema = "Invalid")]
[Comment("The major or overriding disability condition that best describes a person's impairment.")]
public partial class RefDisabilityTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
