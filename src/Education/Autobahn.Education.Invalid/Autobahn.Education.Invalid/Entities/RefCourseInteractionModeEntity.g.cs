//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefCourseInteractionModeEntity.g.cs
//* Name:       Course Interaction Mode
//* Definition: The primary type of interaction, synchronous or asynchronous, defined for the course.
//***************************************************************************

/// <summary>
/// Course Interaction Mode <see cref="RefCourseInteractionMode"/>
/// <para>
/// The primary type of interaction, synchronous or asynchronous, defined for the course.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20277">Course Interaction Mode</a>
/// </para>
/// </summary>
[Table("RefCourseInteractionMode", Schema = "Invalid")]
[Comment("The primary type of interaction, synchronous or asynchronous, defined for the course.")]
public partial class RefCourseInteractionModeEntity : ReferenceBaseEntity, IReferenceBase
{
}
