//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefLearningResourceAccessRightsUrlEntity.g.cs
//* Name:       Learning Resource Access Rights URL
//* Definition: A Uniform Resource Locator (URL) that identifies the conditions that govern the user's ability to access a learning resource.
//***************************************************************************

/// <summary>
/// Learning Resource Access Rights URL <see cref="RefLearningResourceAccessRightsUrl"/>
/// <para>
/// A Uniform Resource Locator (URL) that identifies the conditions that govern the user's ability to access a learning resource.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20537">Learning Resource Access Rights URL</a>
/// </para>
/// </summary>
[Table("RefLearningResourceAccessRightsUrl", Schema = "Common")]
[Comment("A Uniform Resource Locator (URL) that identifies the conditions that govern the user's ability to access a learning resource.")]
public partial class RefLearningResourceAccessRightsUrlEntity : ReferenceBaseEntity, IReferenceBase
{
}
