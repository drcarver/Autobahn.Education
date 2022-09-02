//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefLiteracyAssessmentEntity.g.cs
//* Name:       Literacy Assessment Administered Type
//* Definition: The type of literacy test administered.
//***************************************************************************

/// <summary>
/// Literacy Assessment Administered Type <see cref="RefLiteracyAssessment"/>
/// <para>
/// The type of literacy test administered.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19456">Literacy Assessment Administered Type</a>
/// </para>
/// </summary>
[Table("RefLiteracyAssessment", Schema = "Common")]
[Comment("The type of literacy test administered.")]
public partial class RefLiteracyAssessmentEntity : ReferenceBaseEntity, IReferenceBase
{
}
