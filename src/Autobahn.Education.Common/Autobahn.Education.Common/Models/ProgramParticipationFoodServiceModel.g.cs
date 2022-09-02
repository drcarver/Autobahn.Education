//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationFoodServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationFoodService file
/// </summary>
public partial class ProgramParticipationFoodServiceModel : AutobahnBaseModel, IProgramParticipationFoodService
{
    #region "IProgramParticipationFoodService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
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
    public Guid RefSchoolFoodServiceProgramId { get; set; }

    #endregion
}
