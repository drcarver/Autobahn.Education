//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefSpecialEducationAgeGroupTaughtEntity.g.cs
//* Name:       Special Education Age Group Taught
//* Definition: The age range of special education students taught.
//***************************************************************************

/// <summary>
/// Special Education Age Group Taught <see cref="RefSpecialEducationAgeGroupTaught"/>
/// <para>
/// The age range of special education students taught.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19556">Special Education Age Group Taught</a>
/// </para>
/// </summary>
[Table("RefSpecialEducationAgeGroupTaught", Schema = "Common")]
[Comment("The age range of special education students taught.")]
public partial class RefSpecialEducationAgeGroupTaughtEntity : ReferenceBaseEntity, IReferenceBase
{
}
