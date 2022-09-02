//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingSchoolDesignTypeEntity.g.cs
//* Name:       Building School Design Type
//* Definition: The physical layout and character of a school facility, as determined by age groups served and educational programs provided.
//***************************************************************************

/// <summary>
/// Building School Design Type <see cref="RefBuildingSchoolDesignType"/>
/// <para>
/// The physical layout and character of a school facility, as determined by age groups served and educational programs provided.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20809">Building School Design Type</a>
/// </para>
/// </summary>
[Table("RefBuildingSchoolDesignType", Schema = "Facilities")]
[Comment("The physical layout and character of a school facility, as determined by age groups served and educational programs provided.")]
public partial class RefBuildingSchoolDesignTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
