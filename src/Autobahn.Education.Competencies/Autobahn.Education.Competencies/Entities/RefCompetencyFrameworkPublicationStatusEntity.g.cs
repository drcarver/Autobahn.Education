//***************************************************************************
//* DomainName: Competencies
//* FileName:   RefCompetencyFrameworkPublicationStatusEntity.g.cs
//* Name:       Competency Framework Publication Status
//* Definition: The publication status of the competency framework.
//***************************************************************************

/// <summary>
/// Competency Framework Publication Status <see cref="RefCompetencyFrameworkPublicationStatus"/>
/// <para>
/// The publication status of the competency framework.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19675">Competency Framework Publication Status</a>
/// </para>
/// </summary>
[Table("RefCompetencyFrameworkPublicationStatus", Schema = "Competencies")]
[Comment("The publication status of the competency framework.")]
public partial class RefCompetencyFrameworkPublicationStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
