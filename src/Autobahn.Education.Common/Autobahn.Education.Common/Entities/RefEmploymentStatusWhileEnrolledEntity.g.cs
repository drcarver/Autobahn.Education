//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefEmploymentStatusWhileEnrolledEntity.g.cs
//* Name:       Employment Status While Enrolled
//* Definition: An indication of the individual's employment status while enrolled.
//***************************************************************************

/// <summary>
/// Employment Status While Enrolled <see cref="RefEmploymentStatusWhileEnrolled"/>
/// <para>
/// An indication of the individual's employment status while enrolled.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20310">Employment Status While Enrolled</a>
/// </para>
/// </summary>
[Table("RefEmploymentStatusWhileEnrolled", Schema = "Common")]
[Comment("An indication of the individual's employment status while enrolled.")]
public partial class RefEmploymentStatusWhileEnrolledEntity : ReferenceBaseEntity, IReferenceBase
{
}
