//***************************************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationPartEntity.g.cs
//***************************************************************************

/// <summary>
/// The IStaffEvaluationPart file
/// </summary>
[Table("StaffEvaluationPart", Schema = "Common")]
public partial class StaffEvaluationPartEntity : EntityBase, IStaffEvaluationPart
{
    #region "IStaffEvaluationPart Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Staff Evaluation Part Name
    /// <para>
    /// The name of the component part that is being evaluated and scored.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20965">Staff Evaluation Part Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the component part that is being evaluated and scored.")]
    public System.String PartName { get; set; }

    /// <summary>
    /// Staff Evaluation Part Scale
    /// <para>
    /// The quantitative or qualitative range of possible scores/rating for a person's performance on a component part (e.g., 0 - 10; Poor, Fair, Average, Good, Excellent).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20966">Staff Evaluation Part Scale</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The quantitative or qualitative range of possible scores/rating for a person's performance on a component part (e.g., 0 - 10; Poor, Fair, Average, Good, Excellent).")]
    public System.String Scale { get; set; }

    /// <summary>
    /// Staff Evaluation Part Score or Rating
    /// <para>
    /// The actual quantitative or qualitative assessment of a person's performance on a component part that is being evaluated. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20967">Staff Evaluation Part Score or Rating</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The actual quantitative or qualitative assessment of a person's performance on a component part that is being evaluated. ")]
    public System.String ScoreOrRating { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEvaluation"/> model
    /// </summary>
    [ForeignKey("StaffEvaluation")]
    public Guid? StaffEvaluationId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEvaluation"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual StaffEvaluationEntity StaffEvaluationEntity { get; set; }

    #endregion
}
