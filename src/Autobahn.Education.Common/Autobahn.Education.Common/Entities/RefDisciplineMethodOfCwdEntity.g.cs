//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefDisciplineMethodOfCwdEntity.g.cs
//* Name:       Discipline Method of Children with Disabilities
//* Definition: The type of suspension or expulsion used for the discipline of children with disabilities.
//***************************************************************************

/// <summary>
/// Discipline Method of Children with Disabilities <see cref="RefDisciplineMethodOfCwd"/>
/// <para>
/// The type of suspension or expulsion used for the discipline of children with disabilities.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19529">Discipline Method of Children with Disabilities</a>
/// </para>
/// </summary>
[Table("RefDisciplineMethodOfCwd", Schema = "Common")]
[Comment("The type of suspension or expulsion used for the discipline of children with disabilities.")]
public partial class RefDisciplineMethodOfCwdEntity : ReferenceBaseEntity, IReferenceBase
{
}
