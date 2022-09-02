//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCourseCreditLevelTypeEntity.g.cs
//* Name:       Course Credit Level Type
//* Definition: The level of credit associated with the credit hours earned for the course.
//***************************************************************************

/// <summary>
/// Course Credit Level Type <see cref="RefCourseCreditLevelType"/>
/// <para>
/// The level of credit associated with the credit hours earned for the course.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20270">Course Credit Level Type</a>
/// </para>
/// </summary>
[Table("RefCourseCreditLevelType", Schema = "Common")]
[Comment("The level of credit associated with the credit hours earned for the course.")]
public partial class RefCourseCreditLevelTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
