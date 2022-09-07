//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   RefAeFunctioningLevelAtPosttestEntity.g.cs
//* Name:       Adult Educational Functioning Level at Posttest
//* Definition: An individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.
//***************************************************************************

/// <summary>
/// Adult Educational Functioning Level at Posttest <see cref="RefAeFunctioningLevelAtPosttest"/>
/// <para>
/// An individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19764">Adult Educational Functioning Level at Posttest</a>
/// </para>
/// </summary>
[Table("RefAeFunctioningLevelAtPosttest", Schema = "AdultEducation")]
[Comment("An individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.")]
public partial class RefAeFunctioningLevelAtPosttestEntity : ReferenceBaseEntity, IReferenceBase
{
}
