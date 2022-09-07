//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefIncomeCalculationMethodEntity.g.cs
//* Name:       Income Calculation Method
//* Definition: The calculation method used by a program to determine total family income.
//***************************************************************************

/// <summary>
/// Income Calculation Method <see cref="RefIncomeCalculationMethod"/>
/// <para>
/// The calculation method used by a program to determine total family income.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19333">Income Calculation Method</a>
/// </para>
/// </summary>
[Table("RefIncomeCalculationMethod", Schema = "Person")]
[Comment("The calculation method used by a program to determine total family income.")]
public partial class RefIncomeCalculationMethodEntity : ReferenceBaseEntity, IReferenceBase
{
}
