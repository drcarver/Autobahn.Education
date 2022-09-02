//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAcademicAwardLevelEntity.g.cs
//* Name:       Academic Award Level Conferred
//* Definition: An indicator of the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study.   
//***************************************************************************

/// <summary>
/// Academic Award Level Conferred <see cref="RefAcademicAwardLevel"/>
/// <para>
/// An indicator of the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study.   
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19002">Academic Award Level Conferred</a>
/// </para>
/// </summary>
[Table("RefAcademicAwardLevel", Schema = "Common")]
[Comment("An indicator of the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study.   ")]
public partial class RefAcademicAwardLevelEntity : ReferenceBaseEntity, IReferenceBase
{
}
