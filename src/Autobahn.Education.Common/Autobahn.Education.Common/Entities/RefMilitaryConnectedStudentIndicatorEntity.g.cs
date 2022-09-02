//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefMilitaryConnectedStudentIndicatorEntity.g.cs
//* Name:       Military Connected Student Indicator
//* Definition: An indication that the student's parent or guardian is on Active Duty, in the National Guard, or in the Reserve components of the United States military services
//***************************************************************************

/// <summary>
/// Military Connected Student Indicator <see cref="RefMilitaryConnectedStudentIndicator"/>
/// <para>
/// An indication that the student's parent or guardian is on Active Duty, in the National Guard, or in the Reserve components of the United States military services
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20555">Military Connected Student Indicator</a>
/// </para>
/// </summary>
[Table("RefMilitaryConnectedStudentIndicator", Schema = "Common")]
[Comment("An indication that the student's parent or guardian is on Active Duty, in the National Guard, or in the Reserve components of the United States military services")]
public partial class RefMilitaryConnectedStudentIndicatorEntity : ReferenceBaseEntity, IReferenceBase
{
}
