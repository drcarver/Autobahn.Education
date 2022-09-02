//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefFamilyIncomeSourceEntity.g.cs
//* Name:       Source of Family Income
//* Definition: Sources of total family income.
//***************************************************************************

/// <summary>
/// Source of Family Income <see cref="RefFamilyIncomeSource"/>
/// <para>
/// Sources of total family income.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19332">Source of Family Income</a>
/// </para>
/// </summary>
[Table("RefFamilyIncomeSource", Schema = "Common")]
[Comment("Sources of total family income.")]
public partial class RefFamilyIncomeSourceEntity : ReferenceBaseEntity, IReferenceBase
{
}
