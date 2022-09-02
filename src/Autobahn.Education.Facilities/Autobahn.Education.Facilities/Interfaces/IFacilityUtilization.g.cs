//***************************************************************************
//* DomainName: Facilities
//* FileName:   IFacilityUtilization.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityUtilization file
/// </summary>
public partial interface IFacilityUtilization
{
    #region "IFacilityUtilization Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Building Hours of Public Use Per Week
    /// <para>
    /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20837">Building Hours of Public Use Per Week</a>
    /// </para>
    /// </summary>
    Int32? BuildingHoursOfPublicUsePerWeek { get; set; }

    /// <summary>
    /// Building Net Area of Instructional Space
    /// <para>
    /// The area of space directly used for instruction excluding circulation, administration, student services, and building support.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20838">Building Net Area of Instructional Space</a>
    /// </para>
    /// </summary>
    Decimal? BuildingNetAreaOfInstructionalSpace { get; set; }

    /// <summary>
    /// Building Number of Teaching Stations
    /// <para>
    /// The number of teaching stations, as defined by how many spaces have, or could have, a teacher assigned to them for classroom instruction.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20839">Building Number of Teaching Stations</a>
    /// </para>
    /// </summary>
    Int32? BuildingNumberOfTeachingStations { get; set; }

    /// <summary>
    /// Building Public Use Policy Description
    /// <para>
    /// A description of the policy that enables the community or other organizations to use all or part of a building for purposes other than general education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20840">Building Public Use Policy Description</a>
    /// </para>
    /// </summary>
    System.String BuildingPublicUsePolicyDescription { get; set; }

    /// <summary>
    /// Facility Enrollment Capacity
    /// <para>
    /// The maximum number of age appropriate students who can be enrolled in a facility such that the district's programmatic, operational, and student/teacher work load requirements are met.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20885">Facility Enrollment Capacity</a>
    /// </para>
    /// </summary>
    Int32? FacilityEnrollmentCapacity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    Guid FacilityId { get; set; }

    #endregion
}
