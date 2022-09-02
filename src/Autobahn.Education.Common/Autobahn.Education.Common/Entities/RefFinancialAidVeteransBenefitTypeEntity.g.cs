//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefFinancialAidVeteransBenefitTypeEntity.g.cs
//* Name:       Financial Aid Veteran's Benefit Type
//* Definition: The type of Veteran's benefits a person is receiving.
//***************************************************************************

/// <summary>
/// Financial Aid Veteran's Benefit Type <see cref="RefFinancialAidVeteransBenefitType"/>
/// <para>
/// The type of Veteran's benefits a person is receiving.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20589">Financial Aid Veteran's Benefit Type</a>
/// </para>
/// </summary>
[Table("RefFinancialAidVeteransBenefitType", Schema = "Common")]
[Comment("The type of Veteran's benefits a person is receiving.")]
public partial class RefFinancialAidVeteransBenefitTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
