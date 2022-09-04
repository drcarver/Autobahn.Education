//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefPrimaryLearningDeviceAccessEntity.g.cs
//* Name:       Primary Learning Device Access
//* Definition: An indication of whether the primary learning device is shared or not shared with another individual
//***************************************************************************

/// <summary>
/// Primary Learning Device Access <see cref="RefPrimaryLearningDeviceAccess"/>
/// <para>
/// An indication of whether the primary learning device is shared or not shared with another individual
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20952">Primary Learning Device Access</a>
/// </para>
/// </summary>
[Table("RefPrimaryLearningDeviceAccess", Schema = "LearningResources")]
[Comment("An indication of whether the primary learning device is shared or not shared with another individual")]
public partial class RefPrimaryLearningDeviceAccessEntity : ReferenceBaseEntity, IReferenceBase
{
}
