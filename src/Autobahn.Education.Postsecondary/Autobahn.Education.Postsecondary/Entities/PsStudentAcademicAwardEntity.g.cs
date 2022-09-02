//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicAwardEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentAcademicAward file
/// </summary>
[Table("PsStudentAcademicAward", Schema = "Postsecondary")]
public partial class PsStudentAcademicAwardEntity : EntityBase, IPsStudentAcademicAward
{
    #region "IPsStudentAcademicAward Properties"
    /// <summary>
    /// Academic Award Date
    /// <para>
    /// The year, month and day or year and month on which the academic award was conferred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19001">Academic Award Date</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(14,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The year, month and day or year and month on which the academic award was conferred.")]
    public System.String AcademicAwardDate { get; set; }

    /// <summary>
    /// Academic Award Title
    /// <para>
    /// The descriptive title for the academic award.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19003">Academic Award Title</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The descriptive title for the academic award.")]
    public System.String AcademicAwardTitle { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Academic Award Level Conferred
    /// <para>
    /// An indicator of the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study.   
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19002">Academic Award Level Conferred</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAcademicAwardLevel")]
    [Comment("An indicator of the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study.   ")]
    public Guid? RefAcademicAwardLevelId { get; set; }

    /// <summary>
    /// Academic Award Prerequisite Type
    /// <para>
    /// Prerequisite conditions for earning an academic award.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20647">Academic Award Prerequisite Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAcademicAwardPrerequisiteType")]
    [Comment("Prerequisite conditions for earning an academic award.")]
    public Guid? RefAcademicAwardPrerequisiteTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPescawardLevelType"/> model
    /// </summary>
    [ForeignKey("RefPescawardLevelType")]
    public Guid? RefPescawardLevelTypeId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String RequirementsUrl { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// An indicator of the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study.   
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19002">Academic Award Level Conferred</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefAcademicAwardLevelEntity RefAcademicAwardLevelEntity { get; set; }

    /// <summary>
    /// Prerequisite conditions for earning an academic award.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20647">Academic Award Prerequisite Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefAcademicAwardPrerequisiteTypeEntity RefAcademicAwardPrerequisiteTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefPescawardLevelType"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefPescawardLevelTypeEntity RefPescawardLevelTypeEntity { get; set; }

    #endregion
}
