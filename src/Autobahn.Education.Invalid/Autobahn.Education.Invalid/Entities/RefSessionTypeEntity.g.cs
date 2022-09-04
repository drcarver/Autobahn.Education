//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefSessionTypeEntity.g.cs
//* Name:       Session Type
//* Definition: A prescribed span of time when an education institution is open, instruction is provided, and students are under the direction and guidance of teachers and/or education institution administration. A session may be interrupted by one or more vacations.
//***************************************************************************

/// <summary>
/// Session Type <see cref="RefSessionType"/>
/// <para>
/// A prescribed span of time when an education institution is open, instruction is provided, and students are under the direction and guidance of teachers and/or education institution administration. A session may be interrupted by one or more vacations.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19254">Session Type</a>
/// </para>
/// </summary>
[Table("RefSessionType", Schema = "Invalid")]
[Comment("A prescribed span of time when an education institution is open, instruction is provided, and students are under the direction and guidance of teachers and/or education institution administration. A session may be interrupted by one or more vacations.")]
public partial class RefSessionTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
