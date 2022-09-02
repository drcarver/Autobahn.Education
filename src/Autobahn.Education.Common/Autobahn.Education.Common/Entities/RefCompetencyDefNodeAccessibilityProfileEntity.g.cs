//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCompetencyDefNodeAccessibilityProfileEntity.g.cs
//* Name:       Competency Definition Node Accessibility Profile
//* Definition: When the Competency Definition is used as a node in a learning map, this element supports alternative pathways based on a learner's accessibility profile. The type selected indicates which accessibility profile the node is designed to address.
//***************************************************************************

/// <summary>
/// Competency Definition Node Accessibility Profile <see cref="RefCompetencyDefNodeAccessibilityProfile"/>
/// <para>
/// When the Competency Definition is used as a node in a learning map, this element supports alternative pathways based on a learner's accessibility profile. The type selected indicates which accessibility profile the node is designed to address.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20377">Competency Definition Node Accessibility Profile</a>
/// </para>
/// </summary>
[Table("RefCompetencyDefNodeAccessibilityProfile", Schema = "Common")]
[Comment("When the Competency Definition is used as a node in a learning map, this element supports alternative pathways based on a learner's accessibility profile. The type selected indicates which accessibility profile the node is designed to address.")]
public partial class RefCompetencyDefNodeAccessibilityProfileEntity : ReferenceBaseEntity, IReferenceBase
{
}
