//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefNonTraditionalGenderStatusEntity.g.cs
//* Name:       Career Technical Education Nontraditional Gender Status
//* Definition: An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).
//***************************************************************************

/// <summary>
/// Career Technical Education Nontraditional Gender Status <see cref="RefNonTraditionalGenderStatus"/>
/// <para>
/// An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19581">Career Technical Education Nontraditional Gender Status</a>
/// </para>
/// </summary>
[Table("RefNonTraditionalGenderStatus", Schema = "Common")]
[Comment("An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).")]
public partial class RefNonTraditionalGenderStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
