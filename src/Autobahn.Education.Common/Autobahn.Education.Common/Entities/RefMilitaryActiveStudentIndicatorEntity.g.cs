//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefMilitaryActiveStudentIndicatorEntity.g.cs
//* Name:       Military Active Student Indicator
//* Definition: An indication that the student is currently serving on Active Duty, in the National Guard, or in the Reserve components of the United States military services
//***************************************************************************

/// <summary>
/// Military Active Student Indicator <see cref="RefMilitaryActiveStudentIndicator"/>
/// <para>
/// An indication that the student is currently serving on Active Duty, in the National Guard, or in the Reserve components of the United States military services
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20556">Military Active Student Indicator</a>
/// </para>
/// </summary>
[Table("RefMilitaryActiveStudentIndicator", Schema = "Common")]
[Comment("An indication that the student is currently serving on Active Duty, in the National Guard, or in the Reserve components of the United States military services")]
public partial class RefMilitaryActiveStudentIndicatorEntity : ReferenceBaseEntity, IReferenceBase
{
}
