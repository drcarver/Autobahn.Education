//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefBillableBasisTypeEntity.g.cs
//* Name:       Billable Basis Type
//* Definition: The event/action that results in a billable action.
//***************************************************************************

/// <summary>
/// Billable Basis Type <see cref="RefBillableBasisType"/>
/// <para>
/// The event/action that results in a billable action.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20561">Billable Basis Type</a>
/// </para>
/// </summary>
[Table("RefBillableBasisType", Schema = "Common")]
[Comment("The event/action that results in a billable action.")]
public partial class RefBillableBasisTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
