//***************************************************************************
//* DomainName: Competencies
//* FileName:   RefCompetencyDefAssociationTypeEntity.g.cs
//* Name:       Competency Association Type
//* Definition: Defines the nature of the association between a Competency Definition and an associated data object such as a Learning Resource, an Assessment Item, or even another Competency Definition.
//***************************************************************************

/// <summary>
/// Competency Association Type <see cref="RefCompetencyDefAssociationType"/>
/// <para>
/// Defines the nature of the association between a Competency Definition and an associated data object such as a Learning Resource, an Assessment Item, or even another Competency Definition.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19869">Competency Association Type</a>
/// </para>
/// </summary>
[Table("RefCompetencyDefAssociationType", Schema = "Competencies")]
[Comment("Defines the nature of the association between a Competency Definition and an associated data object such as a Learning Resource, an Assessment Item, or even another Competency Definition.")]
public partial class RefCompetencyDefAssociationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
