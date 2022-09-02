//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingAirDistributionSystemTypeEntity.g.cs
//* Name:       Building Air Distribution System Type
//* Definition: The primary means by which air is circulated, freshened, and exhausted.
//***************************************************************************

/// <summary>
/// Building Air Distribution System Type <see cref="RefBuildingAirDistributionSystemType"/>
/// <para>
/// The primary means by which air is circulated, freshened, and exhausted.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20771">Building Air Distribution System Type</a>
/// </para>
/// </summary>
[Table("RefBuildingAirDistributionSystemType", Schema = "Facilities")]
[Comment("The primary means by which air is circulated, freshened, and exhausted.")]
public partial class RefBuildingAirDistributionSystemTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
