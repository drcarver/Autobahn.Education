//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsProgramEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsProgram file
/// </summary>
[Table("PsProgram", Schema = "Postsecondary")]
public partial class PsProgramEntity : EntityBase, IPsProgram
{
    #region "IPsProgram Properties"
    /// <summary>
    /// Normal Length of Time for Completion
    /// <para>
    /// The amount of time necessary for a person to complete all requirements for a degree or certificate according to the institution's catalog. This is typically 4 years (8 semesters or trimesters, or 12 quarters, excluding summer terms) for a bachelor's degree in a standard term-based institution; 2 years (4 semesters or trimesters, or 6 quarters, excluding summer terms) for an associate's degree in a standard term-based institution; and the various scheduled times for certificate programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19197">Normal Length of Time for Completion</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The amount of time necessary for a person to complete all requirements for a degree or certificate according to the institution's catalog. This is typically 4 years (8 semesters or trimesters, or 12 quarters, excluding summer terms) for a bachelor's degree in a standard term-based institution; 2 years (4 semesters or trimesters, or 6 quarters, excluding summer terms) for an associate's degree in a standard term-based institution; and the various scheduled times for certificate programs.")]
    public System.String NormalLengthTimeForCompletion { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Program Length Hours
    /// <para>
    /// The normal length in credit/contact hours of a person's program as published in the institution's catalogue, website, or other official documents.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19223">Program Length Hours</a>
    /// </para>
    /// </summary>
    [Comment("The normal length in credit/contact hours of a person's program as published in the institution's catalogue, website, or other official documents.")]
    public Decimal? ProgramLengthHours { get; set; }

    /// <summary>
    /// Classification of Instructional Program Code
    /// <para>
    /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCipCode")]
    [Comment("A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.")]
    public Guid? RefCipCodeId { get; set; }

    /// <summary>
    /// Classification of Instructional Program Version
    /// <para>
    /// The version of CIP being reported.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19045">Classification of Instructional Program Version</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCipVersion")]
    [Comment("The version of CIP being reported.")]
    public Guid? RefCipVersionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDqpcategoriesOfLearning"/> model
    /// </summary>
    [ForeignKey("RefDqpcategoriesOfLearning")]
    public Guid? RefDqpcategoriesOfLearningId { get; set; }

    /// <summary>
    /// Program Length Hours Type
    /// <para>
    /// The type of hours (credit or contact) by which the normal length of a program of study is measured.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19224">Program Length Hours Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefProgramLengthHoursType")]
    [Comment("The type of hours (credit or contact) by which the normal length of a program of study is measured.")]
    public Guid? RefProgramLengthHoursTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPsprogramLevel"/> model
    /// </summary>
    [ForeignKey("RefPsprogramLevel")]
    public Guid? RefPsprogramLevelId { get; set; }

    /// <summary>
    /// Normal Length of Time for Completion Units
    /// <para>
    /// The unit of measurement for length of time for completion.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19198">Normal Length of Time for Completion Units</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTimeForCompletionUnits")]
    [Comment("The unit of measurement for length of time for completion.")]
    public Guid? RefTimeForCompletionUnitsId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The version of CIP being reported.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19045">Classification of Instructional Program Version</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefCipVersionEntity? RefCipVersionEntity { get; set; }

    /// <summary>
    /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefCipCodeEntity? RefCipCodeEntity { get; set; }

    /// <summary>
    /// The type of hours (credit or contact) by which the normal length of a program of study is measured.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19224">Program Length Hours Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefProgramLengthHoursTypeEntity? RefProgramLengthHoursTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefPsprogramLevel"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefPsprogramLevelEntity? RefPsprogramLevelEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefDqpcategoriesOfLearning"/> implementation
    /// <remarks>
    /// This entity is in the Postsecondary domain
    /// </remarks>
    /// </summary>
    public virtual RefDqpcategoriesOfLearningEntity? RefDqpcategoriesOfLearningEntity { get; set; }

    #endregion
}
