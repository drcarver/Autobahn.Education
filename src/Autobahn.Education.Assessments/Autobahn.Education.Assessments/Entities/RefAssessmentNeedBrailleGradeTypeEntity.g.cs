//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentNeedBrailleGradeTypeEntity.g.cs
//* Name:       Assessment Need Braille Grade Type
//* Definition: Defines as part of an Assessment Personal Needs Profile the grade of Braille to use when using a Braille display.
//***************************************************************************

/// <summary>
/// Assessment Need Braille Grade Type <see cref="RefAssessmentNeedBrailleGradeType"/>
/// <para>
/// Defines as part of an Assessment Personal Needs Profile the grade of Braille to use when using a Braille display.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20035">Assessment Need Braille Grade Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentNeedBrailleGradeType", Schema = "Assessments")]
[Comment("Defines as part of an Assessment Personal Needs Profile the grade of Braille to use when using a Braille display.")]
public partial class RefAssessmentNeedBrailleGradeTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
