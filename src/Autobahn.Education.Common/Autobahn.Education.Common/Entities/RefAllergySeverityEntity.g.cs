//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAllergySeverityEntity.g.cs
//* Name:       Allergy Severity
//* Definition: The level of severity of a person's reaction to an allergen.
//***************************************************************************

/// <summary>
/// Allergy Severity <see cref="RefAllergySeverity"/>
/// <para>
/// The level of severity of a person's reaction to an allergen.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20248">Allergy Severity</a>
/// </para>
/// </summary>
[Table("RefAllergySeverity", Schema = "Common")]
[Comment("The level of severity of a person's reaction to an allergen.")]
public partial class RefAllergySeverityEntity : ReferenceBaseEntity, IReferenceBase
{
}
