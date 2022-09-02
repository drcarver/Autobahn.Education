//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefHighSchoolGraduationRateIndicatorEntity.g.cs
//* Name:       High School Graduation Rate Indicator Status
//* Definition: An indication of whether the school or district met the High School Graduation Rate requirement in accordance with state definition for the purposes of determining AYP.
//***************************************************************************

/// <summary>
/// High School Graduation Rate Indicator Status <see cref="RefHighSchoolGraduationRateIndicator"/>
/// <para>
/// An indication of whether the school or district met the High School Graduation Rate requirement in accordance with state definition for the purposes of determining AYP.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19140">High School Graduation Rate Indicator Status</a>
/// </para>
/// </summary>
[Table("RefHighSchoolGraduationRateIndicator", Schema = "Common")]
[Comment("An indication of whether the school or district met the High School Graduation Rate requirement in accordance with state definition for the purposes of determining AYP.")]
public partial class RefHighSchoolGraduationRateIndicatorEntity : ReferenceBaseEntity, IReferenceBase
{
}
