//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefScheduledWellChildScreeningEntity.g.cs
//* Name:       Scheduled Well Child Screening
//* Definition: The individual well child visit scheduled according to the AAP recommended periodicity schedule.
//***************************************************************************

/// <summary>
/// Scheduled Well Child Screening <see cref="RefScheduledWellChildScreening"/>
/// <para>
/// The individual well child visit scheduled according to the AAP recommended periodicity schedule.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20602">Scheduled Well Child Screening</a>
/// </para>
/// </summary>
[Table("RefScheduledWellChildScreening", Schema = "Common")]
[Comment("The individual well child visit scheduled according to the AAP recommended periodicity schedule.")]
public partial class RefScheduledWellChildScreeningEntity : ReferenceBaseEntity, IReferenceBase
{
}
