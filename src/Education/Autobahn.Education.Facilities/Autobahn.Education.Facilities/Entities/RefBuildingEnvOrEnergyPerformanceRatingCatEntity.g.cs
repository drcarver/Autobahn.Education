//***************************************************************************
//* DomainName: Facilities
//* FileName:   RefBuildingEnvOrEnergyPerformanceRatingCatEntity.g.cs
//* Name:       Building Environmental or Energy Performance Rating Category
//* Definition: The primary groupings that rating organizations use to evaluate environmental sustainability and energy use.
//***************************************************************************

/// <summary>
/// Building Environmental or Energy Performance Rating Category <see cref="RefBuildingEnvOrEnergyPerformanceRatingCat"/>
/// <para>
/// The primary groupings that rating organizations use to evaluate environmental sustainability and energy use.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20800">Building Environmental or Energy Performance Rating Category</a>
/// </para>
/// </summary>
[Table("RefBuildingEnvOrEnergyPerformanceRatingCat", Schema = "Facilities")]
[Comment("The primary groupings that rating organizations use to evaluate environmental sustainability and energy use.")]
public partial class RefBuildingEnvOrEnergyPerformanceRatingCatEntity : ReferenceBaseEntity, IReferenceBase
{
}
