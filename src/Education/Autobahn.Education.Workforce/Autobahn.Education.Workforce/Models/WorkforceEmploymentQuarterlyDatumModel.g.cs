//***************************************************************************
//* DomainName: Workforce
//* FileName:   WorkforceEmploymentQuarterlyDatumEntity.g.cs
//***************************************************************************

/// <summary>
/// The IWorkforceEmploymentQuarterlyDatum file
/// </summary>
public partial class WorkforceEmploymentQuarterlyDatumModel : AutobahnBaseModel, IWorkforceEmploymentQuarterlyDatum
{
    #region "IWorkforceEmploymentQuarterlyDatum Properties"
    public Decimal? EmployedInMultipleJobsCount { get; set; }

    public Boolean? MilitaryEnlistmentAfterExit { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
    /// </summary>
    public Guid? RefEmployedAfterExitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
    /// </summary>
    public Guid? RefEmployedWhileEnrolledId { get; set; }

    #endregion
}
