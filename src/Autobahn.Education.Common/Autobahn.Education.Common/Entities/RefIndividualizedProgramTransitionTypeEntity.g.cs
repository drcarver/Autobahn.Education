//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefIndividualizedProgramTransitionTypeEntity.g.cs
//* Name:       Individualized Program Transition Plan Type
//* Definition: The post-school transition plan for the student recorded on their Individualized Education Program.
//***************************************************************************

/// <summary>
/// Individualized Program Transition Plan Type <see cref="RefIndividualizedProgramTransitionType"/>
/// <para>
/// The post-school transition plan for the student recorded on their Individualized Education Program.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20200">Individualized Program Transition Plan Type</a>
/// </para>
/// </summary>
[Table("RefIndividualizedProgramTransitionType", Schema = "Common")]
[Comment("The post-school transition plan for the student recorded on their Individualized Education Program.")]
public partial class RefIndividualizedProgramTransitionTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
