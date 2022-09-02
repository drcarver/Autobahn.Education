//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingFullServiceKitchenTypeEntity.g.cs
//* Name:       Building Full Service Kitchen Type
//* Definition: The type of kitchen housed in the facility as defined by whether it prepares food to be served onsite and/or at additional locations.
//***************************************************************************

/// <summary>
/// Building Full Service Kitchen Type <see cref="RefBuildingFullServiceKitchenType"/>
/// <para>
/// The type of kitchen housed in the facility as defined by whether it prepares food to be served onsite and/or at additional locations.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20824">Building Full Service Kitchen Type</a>
/// </para>
/// </summary>
[Table("RefBuildingFullServiceKitchenType", Schema = "Facilities")]
[Comment("The type of kitchen housed in the facility as defined by whether it prepares food to be served onsite and/or at additional locations.")]
public partial class RefBuildingFullServiceKitchenTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
