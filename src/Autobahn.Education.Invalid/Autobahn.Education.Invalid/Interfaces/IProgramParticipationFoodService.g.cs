//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IProgramParticipationFoodService.g.cs
//***************************************************************************

/// <summary>
/// The IProgramParticipationFoodService file
/// </summary>
public partial interface IProgramParticipationFoodService
{
    #region "IProgramParticipationFoodService Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
    /// </summary>
    Guid PersonProgramParticipationId { get; set; }

    /// <summary>
    /// Participation in School Food Service Programs
    /// <para>
    /// An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19325">Participation in School Food Service Programs</a>
    /// </para>
    /// </summary>
    Guid RefSchoolFoodServiceProgramId { get; set; }

    #endregion
}
