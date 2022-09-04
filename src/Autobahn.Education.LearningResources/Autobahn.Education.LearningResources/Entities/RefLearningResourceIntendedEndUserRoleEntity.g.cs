//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   RefLearningResourceIntendedEndUserRoleEntity.g.cs
//* Name:       Learning Resource Intended End User Role
//* Definition: The individual or group for which the resource was produced.
//***************************************************************************

/// <summary>
/// Learning Resource Intended End User Role <see cref="RefLearningResourceIntendedEndUserRole"/>
/// <para>
/// The individual or group for which the resource was produced.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19924">Learning Resource Intended End User Role</a>
/// </para>
/// </summary>
[Table("RefLearningResourceIntendedEndUserRole", Schema = "LearningResources")]
[Comment("The individual or group for which the resource was produced.")]
public partial class RefLearningResourceIntendedEndUserRoleEntity : ReferenceBaseEntity, IReferenceBase
{
}
