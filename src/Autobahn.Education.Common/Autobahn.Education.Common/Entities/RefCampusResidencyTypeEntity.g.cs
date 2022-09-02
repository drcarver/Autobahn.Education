//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCampusResidencyTypeEntity.g.cs
//* Name:       Campus Residency Type
//* Definition: A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
//***************************************************************************

/// <summary>
/// Campus Residency Type <see cref="RefCampusResidencyType"/>
/// <para>
/// A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19035">Campus Residency Type</a>
/// </para>
/// </summary>
[Table("RefCampusResidencyType", Schema = "Common")]
[Comment("A person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).")]
public partial class RefCampusResidencyTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
