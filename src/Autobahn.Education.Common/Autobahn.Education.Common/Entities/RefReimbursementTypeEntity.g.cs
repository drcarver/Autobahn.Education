//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefReimbursementTypeEntity.g.cs
//* Name:       Reimbursement Type
//* Definition: A billable basis which defines payment. This is how state agencies/programs move funding to the local provider/agency.
//***************************************************************************

/// <summary>
/// Reimbursement Type <see cref="RefReimbursementType"/>
/// <para>
/// A billable basis which defines payment. This is how state agencies/programs move funding to the local provider/agency.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20601">Reimbursement Type</a>
/// </para>
/// </summary>
[Table("RefReimbursementType", Schema = "Common")]
[Comment("A billable basis which defines payment. This is how state agencies/programs move funding to the local provider/agency.")]
public partial class RefReimbursementTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
