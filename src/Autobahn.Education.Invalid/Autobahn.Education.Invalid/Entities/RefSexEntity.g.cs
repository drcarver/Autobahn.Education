//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefSexEntity.g.cs
//* Name:       Sex
//* Definition: The concept describing the biological traits that distinguish the males and females of a species.
//***************************************************************************

/// <summary>
/// Sex <see cref="RefSex"/>
/// <para>
/// The concept describing the biological traits that distinguish the males and females of a species.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19255">Sex</a>
/// </para>
/// </summary>
[Table("RefSex", Schema = "Invalid")]
[Comment("The concept describing the biological traits that distinguish the males and females of a species.")]
public partial class RefSexEntity : ReferenceBaseEntity, IReferenceBase
{
}
