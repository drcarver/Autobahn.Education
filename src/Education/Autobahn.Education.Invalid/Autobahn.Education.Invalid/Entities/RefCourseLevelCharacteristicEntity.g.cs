//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefCourseLevelCharacteristicEntity.g.cs
//* Name:       Course Level Characteristic
//* Definition: An indication of the general nature and difficulty of instruction provided throughout a course.
//***************************************************************************

/// <summary>
/// Course Level Characteristic <see cref="RefCourseLevelCharacteristic"/>
/// <para>
/// An indication of the general nature and difficulty of instruction provided throughout a course.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19061">Course Level Characteristic</a>
/// </para>
/// </summary>
[Table("RefCourseLevelCharacteristic", Schema = "Invalid")]
[Comment("An indication of the general nature and difficulty of instruction provided throughout a course.")]
public partial class RefCourseLevelCharacteristicEntity : ReferenceBaseEntity, IReferenceBase
{
}
