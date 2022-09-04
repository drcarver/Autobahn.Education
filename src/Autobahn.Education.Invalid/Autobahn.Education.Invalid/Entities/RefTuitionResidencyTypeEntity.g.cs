//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefTuitionResidencyTypeEntity.g.cs
//* Name:       Tuition Residency Type
//* Definition: A person's residency status for tuition purposes.
//***************************************************************************

/// <summary>
/// Tuition Residency Type <see cref="RefTuitionResidencyType"/>
/// <para>
/// A person's residency status for tuition purposes.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19297">Tuition Residency Type</a>
/// </para>
/// </summary>
[Table("RefTuitionResidencyType", Schema = "Invalid")]
[Comment("A person's residency status for tuition purposes.")]
public partial class RefTuitionResidencyTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
