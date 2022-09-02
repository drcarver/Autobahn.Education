//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCourseSectionEntryTypeEntity.g.cs
//* Name:       Course Section Entry Type
//* Definition: The process by which a student enters a school (Course Section) during a given academic session.
//***************************************************************************

/// <summary>
/// Course Section Entry Type <see cref="RefCourseSectionEntryType"/>
/// <para>
/// The process by which a student enters a school (Course Section) during a given academic session.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19652">Course Section Entry Type</a>
/// </para>
/// </summary>
[Table("RefCourseSectionEntryType", Schema = "Common")]
[Comment("The process by which a student enters a school (Course Section) during a given academic session.")]
public partial class RefCourseSectionEntryTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
