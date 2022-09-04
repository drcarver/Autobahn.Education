//***************************************************************************
//* DomainName: Role Models
//* FileName:   RefTeachingAssignmentRoleEntity.g.cs
//* Name:       Teaching Assignment Role
//* Definition: The role that the Staff Member has been assigned for a Class Section.  (A teacher may have the lead responsibility for one section and serve a supporting role for another section of the same course.)
//***************************************************************************

/// <summary>
/// Teaching Assignment Role <see cref="RefTeachingAssignmentRole"/>
/// <para>
/// The role that the Staff Member has been assigned for a Class Section.  (A teacher may have the lead responsibility for one section and serve a supporting role for another section of the same course.)
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19650">Teaching Assignment Role</a>
/// </para>
/// </summary>
[Table("RefTeachingAssignmentRole", Schema = "Autobahn.Core.Role")]
[Comment("The role that the Staff Member has been assigned for a Class Section.  (A teacher may have the lead responsibility for one section and serve a supporting role for another section of the same course.)")]
public partial class RefTeachingAssignmentRoleEntity : ReferenceBaseEntity, IReferenceBase
{
}
