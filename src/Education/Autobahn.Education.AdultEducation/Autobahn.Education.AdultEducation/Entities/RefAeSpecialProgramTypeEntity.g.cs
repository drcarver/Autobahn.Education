//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   RefAeSpecialProgramTypeEntity.g.cs
//* Name:       Adult Education Special Program Type
//* Definition: The type, by location or delivery mode, of adult education instruction program in which an adult participates.
//***************************************************************************

/// <summary>
/// Adult Education Special Program Type <see cref="RefAeSpecialProgramType"/>
/// <para>
/// The type, by location or delivery mode, of adult education instruction program in which an adult participates.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19766">Adult Education Special Program Type</a>
/// </para>
/// </summary>
[Table("RefAeSpecialProgramType", Schema = "AdultEducation")]
[Comment("The type, by location or delivery mode, of adult education instruction program in which an adult participates.")]
public partial class RefAeSpecialProgramTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
