//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPsSectionLocation.g.cs
//***************************************************************************

/// <summary>
/// The IPsSectionLocation file
/// </summary>
public partial interface IPsSectionLocation
{
    #region "IPsSectionLocation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Course Instruction Site Name
    /// <para>
    /// The name of the location at which the course is taught.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20275">Course Instruction Site Name</a>
    /// </para>
    /// </summary>
    System.String CourseInstructionSiteName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPsSection"/> model
    /// </summary>
    Guid PsSectionId { get; set; }

    /// <summary>
    /// Course Instruction Site Type
    /// <para>
    /// An indication of the type of location at which the course is taught.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20276">Course Instruction Site Type</a>
    /// </para>
    /// </summary>
    Guid? RefCourseInstructionSiteTypeId { get; set; }

    #endregion
}
