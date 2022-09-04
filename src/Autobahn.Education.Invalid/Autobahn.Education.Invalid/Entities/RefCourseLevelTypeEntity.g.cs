//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefCourseLevelTypeEntity.g.cs
//* Name:       Course Level Type
//* Definition: The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
//***************************************************************************

/// <summary>
/// Course Level Type <see cref="RefCourseLevelType"/>
/// <para>
/// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20278">Course Level Type</a>
/// </para>
/// </summary>
[Table("RefCourseLevelType", Schema = "Invalid")]
[Comment("The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.")]
public partial class RefCourseLevelTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
