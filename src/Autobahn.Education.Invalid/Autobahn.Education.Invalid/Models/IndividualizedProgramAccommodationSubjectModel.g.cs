//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IndividualizedProgramAccommodationSubjectEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAccommodationSubject file
/// </summary>
public partial class IndividualizedProgramAccommodationSubjectModel : AutobahnBaseModel, IIndividualizedProgramAccommodationSubject
{
    #region "IIndividualizedProgramAccommodationSubject Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramAccommodation"/> model
    /// </summary>
    public Guid IndividualizedProgramAccommodationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
    /// </summary>
    public Guid RefScedcourseSubjectAreaId { get; set; }

    #endregion
}
