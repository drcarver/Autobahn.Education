//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefHealthInsuranceCoverageEntity.g.cs
//* Name:       Insurance Coverage
//* Definition: The nature of insurance covering an person's hospitalization and other health or medical care.
//***************************************************************************

/// <summary>
/// Insurance Coverage <see cref="RefHealthInsuranceCoverage"/>
/// <para>
/// The nature of insurance covering an person's hospitalization and other health or medical care.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19334">Insurance Coverage</a>
/// </para>
/// </summary>
[Table("RefHealthInsuranceCoverage", Schema = "Common")]
[Comment("The nature of insurance covering an person's hospitalization and other health or medical care.")]
public partial class RefHealthInsuranceCoverageEntity : ReferenceBaseEntity, IReferenceBase
{
}
