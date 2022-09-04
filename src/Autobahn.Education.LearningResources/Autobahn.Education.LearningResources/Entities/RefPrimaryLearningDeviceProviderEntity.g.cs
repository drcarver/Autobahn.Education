//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefPrimaryLearningDeviceProviderEntity.g.cs
//* Name:       Primary Learning Device Provider
//* Definition: The provider of the primary learning device.
//***************************************************************************

/// <summary>
/// Primary Learning Device Provider <see cref="RefPrimaryLearningDeviceProvider"/>
/// <para>
/// The provider of the primary learning device.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20954">Primary Learning Device Provider</a>
/// </para>
/// </summary>
[Table("RefPrimaryLearningDeviceProvider", Schema = "LearningResources")]
[Comment("The provider of the primary learning device.")]
public partial class RefPrimaryLearningDeviceProviderEntity : ReferenceBaseEntity, IReferenceBase
{
}
