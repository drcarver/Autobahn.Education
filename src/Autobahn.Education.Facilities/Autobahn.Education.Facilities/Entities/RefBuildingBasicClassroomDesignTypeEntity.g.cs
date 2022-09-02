//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingBasicClassroomDesignTypeEntity.g.cs
//* Name:       Building Basic Classroom Design Type
//* Definition: A classroom designed for instruction of a particular age group, but not a specific subject.
//***************************************************************************

/// <summary>
/// Building Basic Classroom Design Type <see cref="RefBuildingBasicClassroomDesignType"/>
/// <para>
/// A classroom designed for instruction of a particular age group, but not a specific subject.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20796">Building Basic Classroom Design Type</a>
/// </para>
/// </summary>
[Table("RefBuildingBasicClassroomDesignType", Schema = "Facilities")]
[Comment("A classroom designed for instruction of a particular age group, but not a specific subject.")]
public partial class RefBuildingBasicClassroomDesignTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
