//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentSubtestIdentifierTypeEntity.g.cs
//* Name:       Assessment Subtest Identifier Type
//* Definition: The type of identifier that is provided for a Subtest.
//***************************************************************************

/// <summary>
/// Assessment Subtest Identifier Type <see cref="RefAssessmentSubtestIdentifierType"/>
/// <para>
/// The type of identifier that is provided for a Subtest.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20016">Assessment Subtest Identifier Type</a>
/// </para>
/// </summary>
[Table("RefAssessmentSubtestIdentifierType", Schema = "Assessments")]
[Comment("The type of identifier that is provided for a Subtest.")]
public partial class RefAssessmentSubtestIdentifierTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
