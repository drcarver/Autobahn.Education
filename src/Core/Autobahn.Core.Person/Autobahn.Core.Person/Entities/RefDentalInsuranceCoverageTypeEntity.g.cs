//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefDentalInsuranceCoverageTypeEntity.g.cs
//* Name:       Dental Insurance Coverage Type
//* Definition: The source of insurance covering an person's dental care.
//***************************************************************************

/// <summary>
/// Dental Insurance Coverage Type <see cref="RefDentalInsuranceCoverageType"/>
/// <para>
/// The source of insurance covering an person's dental care.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19335">Dental Insurance Coverage Type</a>
/// </para>
/// </summary>
[Table("RefDentalInsuranceCoverageType", Schema = "Person")]
[Comment("The source of insurance covering an person's dental care.")]
public partial class RefDentalInsuranceCoverageTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
