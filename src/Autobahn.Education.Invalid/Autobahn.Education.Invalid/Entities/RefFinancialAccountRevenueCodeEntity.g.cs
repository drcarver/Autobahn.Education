//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefFinancialAccountRevenueCodeEntity.g.cs
//* Name:       Financial Account K12 Revenue Code
//* Definition: These codes are for recording revenue and other receivables by source.  Major revenue categories have codes ending in 00 and are further subdivided.
//***************************************************************************

/// <summary>
/// Financial Account K12 Revenue Code <see cref="RefFinancialAccountRevenueCode"/>
/// <para>
/// These codes are for recording revenue and other receivables by source.  Major revenue categories have codes ending in 00 and are further subdivided.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20440">Financial Account K12 Revenue Code</a>
/// </para>
/// </summary>
[Table("RefFinancialAccountRevenueCode", Schema = "Invalid")]
[Comment("These codes are for recording revenue and other receivables by source.  Major revenue categories have codes ending in 00 and are further subdivided.")]
public partial class RefFinancialAccountRevenueCodeEntity : ReferenceBaseEntity, IReferenceBase
{
}
