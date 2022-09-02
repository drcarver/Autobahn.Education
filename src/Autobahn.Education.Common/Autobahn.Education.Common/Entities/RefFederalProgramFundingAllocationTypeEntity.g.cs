//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefFederalProgramFundingAllocationTypeEntity.g.cs
//* Name:       Federal Programs Funding Allocation Type
//* Definition: The type of federal program funding allocation or distribution made.
//***************************************************************************

/// <summary>
/// Federal Programs Funding Allocation Type <see cref="RefFederalProgramFundingAllocationType"/>
/// <para>
/// The type of federal program funding allocation or distribution made.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19539">Federal Programs Funding Allocation Type</a>
/// </para>
/// </summary>
[Table("RefFederalProgramFundingAllocationType", Schema = "Common")]
[Comment("The type of federal program funding allocation or distribution made.")]
public partial class RefFederalProgramFundingAllocationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
