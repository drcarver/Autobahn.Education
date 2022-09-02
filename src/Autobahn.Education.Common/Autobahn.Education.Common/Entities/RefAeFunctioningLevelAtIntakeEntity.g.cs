//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAeFunctioningLevelAtIntakeEntity.g.cs
//* Name:       Adult Educational Functioning Level at Intake
//* Definition: An individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.
//***************************************************************************

/// <summary>
/// Adult Educational Functioning Level at Intake <see cref="RefAeFunctioningLevelAtIntake"/>
/// <para>
/// An individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19763">Adult Educational Functioning Level at Intake</a>
/// </para>
/// </summary>
[Table("RefAeFunctioningLevelAtIntake", Schema = "Common")]
[Comment("An individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.")]
public partial class RefAeFunctioningLevelAtIntakeEntity : ReferenceBaseEntity, IReferenceBase
{
}
