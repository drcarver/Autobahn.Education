//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingJointUserTypeEntity.g.cs
//* Name:       Building Joint User Type
//* Definition: The types of users sharing school district controlled, owned, or utilized facilities.
//***************************************************************************

/// <summary>
/// Building Joint User Type <see cref="RefBuildingJointUserType"/>
/// <para>
/// The types of users sharing school district controlled, owned, or utilized facilities.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20835">Building Joint User Type</a>
/// </para>
/// </summary>
[Table("RefBuildingJointUserType", Schema = "Facilities")]
[Comment("The types of users sharing school district controlled, owned, or utilized facilities.")]
public partial class RefBuildingJointUserTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
