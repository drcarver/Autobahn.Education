//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefEndOfTermStatusEntity.g.cs
//* Name:       End of Term Status
//* Definition: The nature of the student's progress at the end of a given school term.
//***************************************************************************

/// <summary>
/// End of Term Status <see cref="RefEndOfTermStatus"/>
/// <para>
/// The nature of the student's progress at the end of a given school term.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19093">End of Term Status</a>
/// </para>
/// </summary>
[Table("RefEndOfTermStatus", Schema = "Common")]
[Comment("The nature of the student's progress at the end of a given school term.")]
public partial class RefEndOfTermStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
