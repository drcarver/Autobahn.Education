//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefMilitaryBranchEntity.g.cs
//* Name:       Military Branch
//* Definition: A branch of the U.S. Military applicable for specifying more details when using Military Connected Student Indicator, Military Active Student Indicator,  Military Veteran Student Indicator, and Military Enlistment After Exit elements.
//***************************************************************************

/// <summary>
/// Military Branch <see cref="RefMilitaryBranch"/>
/// <para>
/// A branch of the U.S. Military applicable for specifying more details when using Military Connected Student Indicator, Military Active Student Indicator,  Military Veteran Student Indicator, and Military Enlistment After Exit elements.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20621">Military Branch</a>
/// </para>
/// </summary>
[Table("RefMilitaryBranch", Schema = "Person")]
[Comment("A branch of the U.S. Military applicable for specifying more details when using Military Connected Student Indicator, Military Active Student Indicator,  Military Veteran Student Indicator, and Military Enlistment After Exit elements.")]
public partial class RefMilitaryBranchEntity : ReferenceBaseEntity, IReferenceBase
{
}
