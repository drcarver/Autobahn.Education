//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefDirectoryInformationBlockStatusEntity.g.cs
//* Name:       Directory Information Block Status
//* Definition: An indication of whether a individual requested a Family Education Rights and Privacy Act (FERPA) block to withhold the release of the person's directory information.
//***************************************************************************

/// <summary>
/// Directory Information Block Status <see cref="RefDirectoryInformationBlockStatus"/>
/// <para>
/// An indication of whether a individual requested a Family Education Rights and Privacy Act (FERPA) block to withhold the release of the person's directory information.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20569">Directory Information Block Status</a>
/// </para>
/// </summary>
[Table("RefDirectoryInformationBlockStatus", Schema = "Common")]
[Comment("An indication of whether a individual requested a Family Education Rights and Privacy Act (FERPA) block to withhold the release of the person's directory information.")]
public partial class RefDirectoryInformationBlockStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
