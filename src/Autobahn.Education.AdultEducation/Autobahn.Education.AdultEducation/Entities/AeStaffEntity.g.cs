//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStaffEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAeStaff file
/// </summary>
[Table("AeStaff", Schema = "AdultEducation")]
public partial class AeStaffEntity : EntityBase, IAeStaff
{
    #region "IAeStaff Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Adult Education Staff Classification
    /// <para>
    /// The titles of employment, official status, or rank of adult education staff.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19770">Adult Education Staff Classification</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAeStaffClassification")]
    [Comment("The titles of employment, official status, or rank of adult education staff.")]
    public Guid? RefAeStaffClassificationId { get; set; }

    /// <summary>
    /// Adult Education Staff Employment Status
    /// <para>
    /// The condition under which a person has agreed to serve as an employee.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19771">Adult Education Staff Employment Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAeStaffEmploymentStatus")]
    [Comment("The condition under which a person has agreed to serve as an employee.")]
    public Guid? RefAeStaffEmploymentStatusId { get; set; }

    /// <summary>
    /// Years of Prior Adult Education Teaching Experience
    /// <para>
    /// The total number of years that a person has previously held a teaching position in one or more adult education programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19774">Years of Prior Adult Education Teaching Experience</a>
    /// </para>
    /// </summary>
    [Comment("The total number of years that a person has previously held a teaching position in one or more adult education programs.")]
    public Decimal? YearsOfPriorAeTeachingExperience { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The titles of employment, official status, or rank of adult education staff.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19770">Adult Education Staff Classification</a>
    /// </para>
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefAeStaffClassificationEntity? RefAeStaffClassificationEntity { get; set; }

    /// <summary>
    /// The condition under which a person has agreed to serve as an employee.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19771">Adult Education Staff Employment Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the AdultEducation domain
    /// </remarks>
    /// </summary>
    public virtual RefAeStaffEmploymentStatusEntity? RefAeStaffEmploymentStatusEntity { get; set; }

    #endregion
}
