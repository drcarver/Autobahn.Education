//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAcademicSubjectEntity.g.cs
//* Name:       Assessment Academic Subject
//* Definition: The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
//***************************************************************************

/// <summary>
/// Assessment Academic Subject <see cref="RefAcademicSubject"/>
/// <para>
/// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19021">Assessment Academic Subject</a>
/// </para>
/// </summary>
[Table("RefAcademicSubject", Schema = "Common")]
[Comment("The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.")]
public partial class RefAcademicSubjectEntity : ReferenceBaseEntity, IReferenceBase
{
}
