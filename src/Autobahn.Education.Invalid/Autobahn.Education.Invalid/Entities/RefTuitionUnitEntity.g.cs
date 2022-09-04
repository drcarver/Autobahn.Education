//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefTuitionUnitEntity.g.cs
//* Name:       Tuition Unit
//* Definition: The component for which tuition is being charged.  It might be a time period (term, quarter, year, etc.) or it might be an entity of education (course, credit hour, etc.).
//***************************************************************************

/// <summary>
/// Tuition Unit <see cref="RefTuitionUnit"/>
/// <para>
/// The component for which tuition is being charged.  It might be a time period (term, quarter, year, etc.) or it might be an entity of education (course, credit hour, etc.).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19725">Tuition Unit</a>
/// </para>
/// </summary>
[Table("RefTuitionUnit", Schema = "Invalid")]
[Comment("The component for which tuition is being charged.  It might be a time period (term, quarter, year, etc.) or it might be an entity of education (course, credit hour, etc.).")]
public partial class RefTuitionUnitEntity : ReferenceBaseEntity, IReferenceBase
{
}
