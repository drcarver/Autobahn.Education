//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingSpaceDesignTypeEntity.g.cs
//* Name:       Building Space Design Type
//* Definition: The primary design or purpose of a space, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
//***************************************************************************

/// <summary>
/// Building Space Design Type <see cref="RefBuildingSpaceDesignType"/>
/// <para>
/// The primary design or purpose of a space, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20812">Building Space Design Type</a>
/// </para>
/// </summary>
[Table("RefBuildingSpaceDesignType", Schema = "Facilities")]
[Comment("The primary design or purpose of a space, as determined by its physical layout and built-in systems and equipment, regardless of its current use.")]
public partial class RefBuildingSpaceDesignTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
