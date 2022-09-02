//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefFullTimeStatusEntity.g.cs
//* Name:       Full-time Status
//* Definition: An indication of whether an individual is employed for a standard number of hours (as determined by civil or organizational policies) in a week, month, or other period of time.
//***************************************************************************

/// <summary>
/// Full-time Status <see cref="RefFullTimeStatus"/>
/// <para>
/// An indication of whether an individual is employed for a standard number of hours (as determined by civil or organizational policies) in a week, month, or other period of time.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19713">Full-time Status</a>
/// </para>
/// </summary>
[Table("RefFullTimeStatus", Schema = "Common")]
[Comment("An indication of whether an individual is employed for a standard number of hours (as determined by civil or organizational policies) in a week, month, or other period of time.")]
public partial class RefFullTimeStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
