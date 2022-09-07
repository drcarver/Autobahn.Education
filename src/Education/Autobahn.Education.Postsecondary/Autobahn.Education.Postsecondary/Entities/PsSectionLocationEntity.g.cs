//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionLocationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsSectionLocation file
/// </summary>
[Table("PsSectionLocation", Schema = "Postsecondary")]
public partial class PsSectionLocationEntity : EntityBase, IPsSectionLocation
{
    #region "IPsSectionLocation Properties"
    /// <summary>
    /// Course Instruction Site Name
    /// <para>
    /// The name of the location at which the course is taught.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20275">Course Instruction Site Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the location at which the course is taught.")]
    public System.String CourseInstructionSiteName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPsSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PsSection")]
    public Guid PsSectionId { get; set; }

    /// <summary>
    /// Course Instruction Site Type
    /// <para>
    /// An indication of the type of location at which the course is taught.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20276">Course Instruction Site Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCourseInstructionSiteType")]
    [Comment("An indication of the type of location at which the course is taught.")]
    public Guid? RefCourseInstructionSiteTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPsSection"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual PsSectionEntity PsSectionEntity { get; set; }

    /// <summary>
    /// An indication of the type of location at which the course is taught.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20276">Course Instruction Site Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefCourseInstructionSiteTypeEntity? RefCourseInstructionSiteTypeEntity { get; set; }

    #endregion
}
