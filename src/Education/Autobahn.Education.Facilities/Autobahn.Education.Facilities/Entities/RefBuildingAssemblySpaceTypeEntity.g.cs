//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingAssemblySpaceTypeEntity.g.cs
//* Name:       Building Assembly Space Type
//* Definition: An area designed primarily for theater productions, assemblies, and other large gatherings.
//***************************************************************************

/// <summary>
/// Building Assembly Space Type <see cref="RefBuildingAssemblySpaceType"/>
/// <para>
/// An area designed primarily for theater productions, assemblies, and other large gatherings.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20817">Building Assembly Space Type</a>
/// </para>
/// </summary>
[Table("RefBuildingAssemblySpaceType", Schema = "Facilities")]
[Comment("An area designed primarily for theater productions, assemblies, and other large gatherings.")]
public partial class RefBuildingAssemblySpaceTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
