//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IIndividualizedProgramAccommodationSubject.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAccommodationSubject file
/// </summary>
public partial interface IIndividualizedProgramAccommodationSubject
{
    #region "IIndividualizedProgramAccommodationSubject Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramAccommodation"/> model
    /// </summary>
    Guid IndividualizedProgramAccommodationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
    /// </summary>
    Guid RefScedcourseSubjectAreaId { get; set; }

    #endregion
}
