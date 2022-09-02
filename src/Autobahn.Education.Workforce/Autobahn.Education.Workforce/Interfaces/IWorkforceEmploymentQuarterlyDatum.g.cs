//***************************************************************************
//* DomainName: Workforce
//* FileName:   IWorkforceEmploymentQuarterlyDatum.g.cs
//***************************************************************************

/// <summary>
/// The IWorkforceEmploymentQuarterlyDatum file
/// </summary>
public partial interface IWorkforceEmploymentQuarterlyDatum
{
    #region "IWorkforceEmploymentQuarterlyDatum Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Decimal? EmployedInMultipleJobsCount { get; set; }

    Boolean? MilitaryEnlistmentAfterExit { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
    /// </summary>
    Guid? RefEmployedAfterExitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
    /// </summary>
    Guid? RefEmployedWhileEnrolledId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IWorkforceEmploymentQuarterlyData"/> model
    /// </summary>
    Guid WorkforceEmploymentQuarterlyDataId { get; set; }

    #endregion
}
