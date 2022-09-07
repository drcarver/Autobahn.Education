//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   RefAeInstructionalProgramTypeEntity.g.cs
//* Name:       Adult Education Instructional Program Type
//* Definition: The type of instructional program in which an adult is enrolled.
//***************************************************************************

/// <summary>
/// Adult Education Instructional Program Type <see cref="RefAeInstructionalProgramType"/>
/// <para>
/// The type of instructional program in which an adult is enrolled.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19765">Adult Education Instructional Program Type</a>
/// </para>
/// </summary>
[Table("RefAeInstructionalProgramType", Schema = "AdultEducation")]
[Comment("The type of instructional program in which an adult is enrolled.")]
public partial class RefAeInstructionalProgramTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
