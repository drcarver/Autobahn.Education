//***************************************************************************
//* DomainName: Competencies
//* FileName:   RefCompetencyDefTestabilityTypeEntity.g.cs
//* Name:       Competency Definition Testability Type
//* Definition: Indicates if the competency described in the Competency Definition Statement can be tested using one or more assessment items.
//***************************************************************************

/// <summary>
/// Competency Definition Testability Type <see cref="RefCompetencyDefTestabilityType"/>
/// <para>
/// Indicates if the competency described in the Competency Definition Statement can be tested using one or more assessment items.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20380">Competency Definition Testability Type</a>
/// </para>
/// </summary>
[Table("RefCompetencyDefTestabilityType", Schema = "Competencies")]
[Comment("Indicates if the competency described in the Competency Definition Statement can be tested using one or more assessment items.")]
public partial class RefCompetencyDefTestabilityTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
