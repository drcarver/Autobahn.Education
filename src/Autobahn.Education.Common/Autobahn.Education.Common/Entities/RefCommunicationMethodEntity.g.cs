//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCommunicationMethodEntity.g.cs
//* Name:       Parent Communication Method
//* Definition: The types of communication methods with parents.
//***************************************************************************

/// <summary>
/// Parent Communication Method <see cref="RefCommunicationMethod"/>
/// <para>
/// The types of communication methods with parents.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19857">Parent Communication Method</a>
/// </para>
/// </summary>
[Table("RefCommunicationMethod", Schema = "Common")]
[Comment("The types of communication methods with parents.")]
public partial class RefCommunicationMethodEntity : ReferenceBaseEntity, IReferenceBase
{
}
