//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ProgramParticipationFoodServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationFoodService file
/// </summary>
[Table("ProgramParticipationFoodService", Schema = "Invalid")]
public partial class ProgramParticipationFoodServiceEntity : EntityBase, IProgramParticipationFoodService
{
    #region "IProgramParticipationFoodService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonProgramParticipation")]
    public Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Participation in School Food Service Programs
    /// <para>
    /// An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19325">Participation in School Food Service Programs</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefSchoolFoodServiceProgram")]
    [Comment("An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.")]
    public Guid RefSchoolFoodServiceProgramId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> implementation
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual PersonProgramParticipationEntity PersonProgramParticipationEntity { get; set; }

    /// <summary>
    /// An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19325">Participation in School Food Service Programs</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefSchoolFoodServiceProgramEntity RefSchoolFoodServiceProgramEntity { get; set; }

    #endregion
}
