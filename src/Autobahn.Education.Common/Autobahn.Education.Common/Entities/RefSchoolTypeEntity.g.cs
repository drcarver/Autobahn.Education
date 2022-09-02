//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefSchoolTypeEntity.g.cs
//* Name:       School Type
//* Definition: The type of education institution as classified by its primary focus. 
//***************************************************************************

/// <summary>
/// School Type <see cref="RefSchoolType"/>
/// <para>
/// The type of education institution as classified by its primary focus. 
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19242">School Type</a>
/// </para>
/// </summary>
[Table("RefSchoolType", Schema = "Common")]
[Comment("The type of education institution as classified by its primary focus. ")]
public partial class RefSchoolTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
