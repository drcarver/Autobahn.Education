//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefBarrierToInternetAccessInResidenceEntity.g.cs
//* Name:       Barrier to Internet Access In Residence
//* Definition: An indication of the barrier to having internet access in the student's primary place of residence.
//***************************************************************************

/// <summary>
/// Barrier to Internet Access In Residence <see cref="RefBarrierToInternetAccessInResidence"/>
/// <para>
/// An indication of the barrier to having internet access in the student's primary place of residence.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20916">Barrier to Internet Access In Residence</a>
/// </para>
/// </summary>
[Table("RefBarrierToInternetAccessInResidence", Schema = "Common")]
[Comment("An indication of the barrier to having internet access in the student's primary place of residence.")]
public partial class RefBarrierToInternetAccessInResidenceEntity : ReferenceBaseEntity, IReferenceBase
{
}
