//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefProfitStatusEntity.g.cs
//* Name:       Facility Profit Status
//* Definition: An indication of the for-profit status of a facility.
//***************************************************************************

/// <summary>
/// Facility Profit Status <see cref="RefProfitStatus"/>
/// <para>
/// An indication of the for-profit status of a facility.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19834">Facility Profit Status</a>
/// </para>
/// </summary>
[Table("RefProfitStatus", Schema = "Common")]
[Comment("An indication of the for-profit status of a facility.")]
public partial class RefProfitStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
