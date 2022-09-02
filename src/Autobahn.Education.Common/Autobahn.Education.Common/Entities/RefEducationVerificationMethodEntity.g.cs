//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefEducationVerificationMethodEntity.g.cs
//* Name:       Education Verification Method
//* Definition: The method by which the formal education is verified.
//***************************************************************************

/// <summary>
/// Education Verification Method <see cref="RefEducationVerificationMethod"/>
/// <para>
/// The method by which the formal education is verified.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20586">Education Verification Method</a>
/// </para>
/// </summary>
[Table("RefEducationVerificationMethod", Schema = "Common")]
[Comment("The method by which the formal education is verified.")]
public partial class RefEducationVerificationMethodEntity : ReferenceBaseEntity, IReferenceBase
{
}
