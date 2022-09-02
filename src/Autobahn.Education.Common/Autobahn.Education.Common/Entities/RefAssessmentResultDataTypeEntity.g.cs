//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefAssessmentResultDataTypeEntity.g.cs
//* Name:       Assessment Result Data Type
//* Definition:  The data type of the assessment result score value.
//***************************************************************************

/// <summary>
/// Assessment Result Data Type <see cref="RefAssessmentResultDataType"/>
/// <para>
///  The data type of the assessment result score value.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20518">Assessment Result Data Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentResultDataType", Schema = "Common")]
[Comment(" The data type of the assessment result score value.")]
public partial class RefAssessmentResultDataTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
