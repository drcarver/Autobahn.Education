//***************************************************************************
//* DomainName: Credentials
//* FileName:   RefCreditTypeEarnedEntity.g.cs
//* Name:       Credit Unit Type
//* Definition: The type of credits or units of value awarded for the completion of a course.
//***************************************************************************

/// <summary>
/// Credit Unit Type <see cref="RefCreditTypeEarned"/>
/// <para>
/// The type of credits or units of value awarded for the completion of a course.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19072">Credit Unit Type</a>
/// </para>
/// </summary>
[Table("RefCreditTypeEarned", Schema = "Credentials")]
[Comment("The type of credits or units of value awarded for the completion of a course.")]
public partial class RefCreditTypeEarnedEntity : ReferenceBaseEntity, IReferenceBase
{
}
