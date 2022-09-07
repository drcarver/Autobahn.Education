//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingDesignTypeEntity.g.cs
//* Name:       Building Design Type
//* Definition: The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
//***************************************************************************

/// <summary>
/// Building Design Type <see cref="RefBuildingDesignType"/>
/// <para>
/// The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20797">Building Design Type</a>
/// </para>
/// </summary>
[Table("RefBuildingDesignType", Schema = "Facilities")]
[Comment("The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.")]
public partial class RefBuildingDesignTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
