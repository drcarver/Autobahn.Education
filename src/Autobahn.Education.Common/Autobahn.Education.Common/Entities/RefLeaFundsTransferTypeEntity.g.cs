//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefLeaFundsTransferTypeEntity.g.cs
//* Name:       Local Education Agency Funds Transfer Type
//* Definition: An indication of the type of transfer for an LEAs that transferred funds from an eligible program to another eligible program.
//***************************************************************************

/// <summary>
/// Local Education Agency Funds Transfer Type <see cref="RefLeaFundsTransferType"/>
/// <para>
/// An indication of the type of transfer for an LEAs that transferred funds from an eligible program to another eligible program.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19441">Local Education Agency Funds Transfer Type</a>
/// </para>
/// </summary>
[Table("RefLeaFundsTransferType", Schema = "Common")]
[Comment("An indication of the type of transfer for an LEAs that transferred funds from an eligible program to another eligible program.")]
public partial class RefLeaFundsTransferTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
