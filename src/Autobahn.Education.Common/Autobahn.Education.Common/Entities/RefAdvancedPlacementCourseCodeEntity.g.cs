//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAdvancedPlacementCourseCodeEntity.g.cs
//* Name:       Advanced Placement Course Code
//* Definition: Course areas for advanced placement or credit.  For a list of codes see http://apcentral.collegeboard.com/apc/public/courses/teachers_corner/index.html .
//***************************************************************************

/// <summary>
/// Advanced Placement Course Code <see cref="RefAdvancedPlacementCourseCode"/>
/// <para>
/// Course areas for advanced placement or credit.  For a list of codes see http://apcentral.collegeboard.com/apc/public/courses/teachers_corner/index.html .
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20244">Advanced Placement Course Code</a>
/// </para>
/// </summary>
[Table("RefAdvancedPlacementCourseCode", Schema = "Common")]
[Comment("Course areas for advanced placement or credit.  For a list of codes see http://apcentral.collegeboard.com/apc/public/courses/teachers_corner/index.html .")]
public partial class RefAdvancedPlacementCourseCodeEntity : ReferenceBaseEntity, IReferenceBase
{
}
