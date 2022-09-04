//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefFinancialAccountCategoryEntity.g.cs
//* Name:       Financial Account Category
//* Definition: A label for a grouping of financial accounts, based on type and purpose.
//***************************************************************************

/// <summary>
/// Financial Account Category <see cref="RefFinancialAccountCategory"/>
/// <para>
/// A label for a grouping of financial accounts, based on type and purpose.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20312">Financial Account Category</a>
/// </para>
/// </summary>
[Table("RefFinancialAccountCategory", Schema = "Invalid")]
[Comment("A label for a grouping of financial accounts, based on type and purpose.")]
public partial class RefFinancialAccountCategoryEntity : ReferenceBaseEntity, IReferenceBase
{
}
