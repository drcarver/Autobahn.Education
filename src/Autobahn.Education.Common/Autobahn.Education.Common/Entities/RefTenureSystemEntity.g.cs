//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefTenureSystemEntity.g.cs
//* Name:       Tenure System
//* Definition: An indicator of whether an institution has personnel positions that lead to consideration for tenure.
//***************************************************************************

/// <summary>
/// Tenure System <see cref="RefTenureSystem"/>
/// <para>
/// An indicator of whether an institution has personnel positions that lead to consideration for tenure.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19715">Tenure System</a>
/// </para>
/// </summary>
[Table("RefTenureSystem", Schema = "Common")]
[Comment("An indicator of whether an institution has personnel positions that lead to consideration for tenure.")]
public partial class RefTenureSystemEntity : ReferenceBaseEntity, IReferenceBase
{
}
