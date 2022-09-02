//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAcademicAwardPrerequisiteTypeEntity.g.cs
//* Name:       Academic Award Prerequisite Type
//* Definition: Prerequisite conditions for earning an academic award.
//***************************************************************************

/// <summary>
/// Academic Award Prerequisite Type <see cref="RefAcademicAwardPrerequisiteType"/>
/// <para>
/// Prerequisite conditions for earning an academic award.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20647">Academic Award Prerequisite Type</a>
/// </para>
/// </summary>
[Table("RefAcademicAwardPrerequisiteType", Schema = "Common")]
[Comment("Prerequisite conditions for earning an academic award.")]
public partial class RefAcademicAwardPrerequisiteTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
