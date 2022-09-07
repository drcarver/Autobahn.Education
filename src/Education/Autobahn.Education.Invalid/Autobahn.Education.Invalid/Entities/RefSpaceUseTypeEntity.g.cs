//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefSpaceUseTypeEntity.g.cs
//* Name:       Facility Space Use Type
//* Definition: The primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.
//***************************************************************************

/// <summary>
/// Facility Space Use Type <see cref="RefSpaceUseType"/>
/// <para>
/// The primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20175">Facility Space Use Type</a>
/// </para>
/// </summary>
[Table("RefSpaceUseType", Schema = "Invalid")]
[Comment("The primary use of a space, as determined by its physical layout and built-in systems and equipment, regardless of its original design.")]
public partial class RefSpaceUseTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
