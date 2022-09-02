//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefMilitaryVeteranStudentIndicatorEntity.g.cs
//* Name:       Military Veteran Student Indicator
//* Definition: An indication that the student is a veteran who served on Active Duty, in the National Guard, or in the Reserve components of the United States military services
//***************************************************************************

/// <summary>
/// Military Veteran Student Indicator <see cref="RefMilitaryVeteranStudentIndicator"/>
/// <para>
/// An indication that the student is a veteran who served on Active Duty, in the National Guard, or in the Reserve components of the United States military services
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20557">Military Veteran Student Indicator</a>
/// </para>
/// </summary>
[Table("RefMilitaryVeteranStudentIndicator", Schema = "Common")]
[Comment("An indication that the student is a veteran who served on Active Duty, in the National Guard, or in the Reserve components of the United States military services")]
public partial class RefMilitaryVeteranStudentIndicatorEntity : ReferenceBaseEntity, IReferenceBase
{
}
