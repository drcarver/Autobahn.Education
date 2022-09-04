//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   StaffEvaluationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IStaffEvaluation file
/// </summary>
[Table("StaffEvaluation", Schema = "Invalid")]
public partial class StaffEvaluationEntity : EntityBase, IStaffEvaluation
{
    #region "IStaffEvaluation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Staff Evaluation Outcome
    /// <para>
    /// The result of an assessment of a person's performance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19102">Staff Evaluation Outcome</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The result of an assessment of a person's performance.")]
    public System.String Outcome { get; set; }

    /// <summary>
    /// Faculty and Administration Performance Level
    /// <para>
    /// The levels used in district evaluation systems for assigning teacher or principal performance ratings.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19582">Faculty and Administration Performance Level</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefStaffPerformanceLevel")]
    [Comment("The levels used in district evaluation systems for assigning teacher or principal performance ratings.")]
    public Guid? RefStaffPerformanceLevelId { get; set; }

    /// <summary>
    /// Staff Evaluation Scale
    /// <para>
    /// The quantitative or qualitative range of possible scores/rating for a person's overall performance (e.g., 0 - 10; Poor, Fair, Average, Good, Excellent).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19103">Staff Evaluation Scale</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The quantitative or qualitative range of possible scores/rating for a person's overall performance (e.g., 0 - 10; Poor, Fair, Average, Good, Excellent).")]
    public System.String Scale { get; set; }

    /// <summary>
    /// Staff Evaluation Score or Rating
    /// <para>
    /// The actual quantitative or qualitative assessment of a person's overall performance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19104">Staff Evaluation Score or Rating</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The actual quantitative or qualitative assessment of a person's overall performance.")]
    public System.String ScoreOrRating { get; set; }

    /// <summary>
    /// Staff Evaluation System
    /// <para>
    /// The instrument and/or set of procedures with which a person's performance is assessed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19105">Staff Evaluation System</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The instrument and/or set of procedures with which a person's performance is assessed.")]
    public System.String System { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The levels used in district evaluation systems for assigning teacher or principal performance ratings.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19582">Faculty and Administration Performance Level</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefStaffPerformanceLevelEntity? RefStaffPerformanceLevelEntity { get; set; }

    #endregion
}
