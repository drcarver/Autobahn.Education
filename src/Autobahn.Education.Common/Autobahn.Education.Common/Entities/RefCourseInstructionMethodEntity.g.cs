//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCourseInstructionMethodEntity.g.cs
//* Name:       Course Instruction Method
//* Definition: The primary method of instruction used for the course.
//***************************************************************************

/// <summary>
/// Course Instruction Method <see cref="RefCourseInstructionMethod"/>
/// <para>
/// The primary method of instruction used for the course.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20274">Course Instruction Method</a>
/// </para>
/// </summary>
[Table("RefCourseInstructionMethod", Schema = "Common")]
[Comment("The primary method of instruction used for the course.")]
public partial class RefCourseInstructionMethodEntity : ReferenceBaseEntity, IReferenceBase
{
}
