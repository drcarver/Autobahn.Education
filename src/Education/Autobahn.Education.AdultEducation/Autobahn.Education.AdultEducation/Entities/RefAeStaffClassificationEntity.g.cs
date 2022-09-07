//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   RefAeStaffClassificationEntity.g.cs
//* Name:       Adult Education Staff Classification
//* Definition: The titles of employment, official status, or rank of adult education staff.
//***************************************************************************

/// <summary>
/// Adult Education Staff Classification <see cref="RefAeStaffClassification"/>
/// <para>
/// The titles of employment, official status, or rank of adult education staff.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19770">Adult Education Staff Classification</a>
/// </para>
/// </summary>
[Table("RefAeStaffClassification", Schema = "AdultEducation")]
[Comment("The titles of employment, official status, or rank of adult education staff.")]
public partial class RefAeStaffClassificationEntity : ReferenceBaseEntity, IReferenceBase
{
}
