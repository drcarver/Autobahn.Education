//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefFacilityUtilityProviderTypeEntity.g.cs
//* Name:       Facility Utility Provider Type
//* Definition: An indication of how utilities are supplied to a site or a building by a company or provider.
//***************************************************************************

/// <summary>
/// Facility Utility Provider Type <see cref="RefFacilityUtilityProviderType"/>
/// <para>
/// An indication of how utilities are supplied to a site or a building by a company or provider.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20859">Facility Utility Provider Type</a>
/// </para>
/// </summary>
[Table("RefFacilityUtilityProviderType", Schema = "Facilities")]
[Comment("An indication of how utilities are supplied to a site or a building by a company or provider.")]
public partial class RefFacilityUtilityProviderTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
