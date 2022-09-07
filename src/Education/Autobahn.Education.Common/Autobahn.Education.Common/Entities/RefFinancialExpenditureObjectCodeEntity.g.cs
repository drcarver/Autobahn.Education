//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefFinancialExpenditureObjectCodeEntity.g.cs
//* Name:       Financial Expenditure K12 Object Code
//* Definition: This classification is used to describe the service or commodity obtained as the result of a specific expenditure.  Nine major object categories have codes ending in 00 and are further subdivided.
//***************************************************************************

/// <summary>
/// Financial Expenditure K12 Object Code <see cref="RefFinancialExpenditureObjectCode"/>
/// <para>
/// This classification is used to describe the service or commodity obtained as the result of a specific expenditure.  Nine major object categories have codes ending in 00 and are further subdivided.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20322">Financial Expenditure K12 Object Code</a>
/// </para>
/// </summary>
[Table("RefFinancialExpenditureObjectCode", Schema = "Common")]
[Comment("This classification is used to describe the service or commodity obtained as the result of a specific expenditure.  Nine major object categories have codes ending in 00 and are further subdivided.")]
public partial class RefFinancialExpenditureObjectCodeEntity : ReferenceBaseEntity, IReferenceBase
{
}
