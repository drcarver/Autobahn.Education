//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCourseSectionExitTypeEntity.g.cs
//* Name:       Course Section Exit Type
//* Definition: The circumstances under which the student exited from membership in a course section.
//***************************************************************************

/// <summary>
/// Course Section Exit Type <see cref="RefCourseSectionExitType"/>
/// <para>
/// The circumstances under which the student exited from membership in a course section.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19654">Course Section Exit Type</a>
/// </para>
/// </summary>
[Table("RefCourseSectionExitType", Schema = "Common")]
[Comment("The circumstances under which the student exited from membership in a course section.")]
public partial class RefCourseSectionExitTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
