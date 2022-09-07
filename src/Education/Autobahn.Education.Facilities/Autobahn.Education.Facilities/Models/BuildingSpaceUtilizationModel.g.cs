//***************************************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceUtilizationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IBuildingSpaceUtilization file
/// </summary>
public partial class BuildingSpaceUtilizationModel : AutobahnBaseModel, IBuildingSpaceUtilization
{
    #region "IBuildingSpaceUtilization Properties"
    /// <summary>
    /// Available Utilized Instructional Space
    /// <para>
    /// An indication that the instruction space in a school is used in the calculation of student capacity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20883">Available Utilized Instructional Space</a>
    /// </para>
    /// </summary>
    public Boolean? AvailableUtilizedInstructionalSpace { get; set; }

    /// <summary>
    /// Building Capacity Factor Indicator
    /// <para>
    /// A designation as to whether the space is included in the calculation of school building capacity under state or local guidelines.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20884">Building Capacity Factor Indicator</a>
    /// </para>
    /// </summary>
    public Boolean? BuildingCapacityFactorIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSpace"/> model
    /// </summary>
    public Guid BuildingSpaceId { get; set; }

    /// <summary>
    /// Building Space Utilization Area
    /// <para>
    /// The area in square feet measured between the principal wall that faces at or near floor level, including alcove spaces, and the outer limits of space designed to serve the activity. Structural space is excluded.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20842">Building Space Utilization Area</a>
    /// </para>
    /// </summary>
    public Decimal? BuildingSpaceUtilizationArea { get; set; }

    /// <summary>
    /// Building Unassigned Space Indicator
    /// <para>
    /// An indication that the space in a school, including circulation, administration offices, support spaces, and common areas, is not part of the calculation for capacity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20844">Building Unassigned Space Indicator</a>
    /// </para>
    /// </summary>
    public Boolean? BuildingUnassignedSpaceIndicator { get; set; }

    /// <summary>
    /// Building Community Use Space Type
    /// <para>
    /// The space designed primarily for community or shared use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20836">Building Community Use Space Type</a>
    /// </para>
    /// </summary>
    public Guid? RefBuildingCommunityUseSpaceTypeId { get; set; }

    /// <summary>
    /// Building Instructional Space Factor Type
    /// <para>
    /// A designation as to whether the space is considered an instructional space under state or local guidelines.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20832">Building Instructional Space Factor Type</a>
    /// </para>
    /// </summary>
    public Guid? RefBuildingInstructionalSpaceFactorTypeId { get; set; }

    #endregion
}
