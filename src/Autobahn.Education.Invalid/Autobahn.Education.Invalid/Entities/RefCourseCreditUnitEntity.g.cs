//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefCourseCreditUnitEntity.g.cs
//* Name:       Course Credit Units
//* Definition: The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
//***************************************************************************

/// <summary>
/// Course Credit Units <see cref="RefCourseCreditUnit"/>
/// <para>
/// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
/// </para>
/// </summary>
[Table("RefCourseCreditUnit", Schema = "Invalid")]
[Comment("The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. ")]
public partial class RefCourseCreditUnitEntity : ReferenceBaseEntity, IReferenceBase
{
}
