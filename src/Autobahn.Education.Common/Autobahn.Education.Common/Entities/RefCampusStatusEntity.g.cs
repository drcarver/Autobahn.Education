//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCampusStatusEntity.g.cs
//* Name:       Campus Status
//* Definition: The generalized use or control of a campus, independent of program type.
//***************************************************************************

/// <summary>
/// Campus Status <see cref="RefCampusStatus"/>
/// <para>
/// The generalized use or control of a campus, independent of program type.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20759">Campus Status</a>
/// </para>
/// </summary>
[Table("RefCampusStatus", Schema = "Common")]
[Comment("The generalized use or control of a campus, independent of program type.")]
public partial class RefCampusStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
