//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingCommunityUseSpaceTypeEntity.g.cs
//* Name:       Building Community Use Space Type
//* Definition: The space designed primarily for community or shared use.
//***************************************************************************

/// <summary>
/// Building Community Use Space Type <see cref="RefBuildingCommunityUseSpaceType"/>
/// <para>
/// The space designed primarily for community or shared use.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20836">Building Community Use Space Type</a>
/// </para>
/// </summary>
[Table("RefBuildingCommunityUseSpaceType", Schema = "Facilities")]
[Comment("The space designed primarily for community or shared use.")]
public partial class RefBuildingCommunityUseSpaceTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
