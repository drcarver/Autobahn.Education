//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefMepStaffCategoryEntity.g.cs
//* Name:       Migrant Education Program Staff Category
//* Definition: Titles of employment, official status, or rank of staff working in the Migrant Education Program (MEP).
//***************************************************************************

/// <summary>
/// Migrant Education Program Staff Category <see cref="RefMepStaffCategory"/>
/// <para>
/// Titles of employment, official status, or rank of staff working in the Migrant Education Program (MEP).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19188">Migrant Education Program Staff Category</a>
/// </para>
/// </summary>
[Table("RefMepStaffCategory", Schema = "Invalid")]
[Comment("Titles of employment, official status, or rank of staff working in the Migrant Education Program (MEP).")]
public partial class RefMepStaffCategoryEntity : ReferenceBaseEntity, IReferenceBase
{
}
