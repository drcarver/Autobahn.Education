//***************************************************************************
//* DomainName: Facilities
//* FileName:   IFacilityManagement.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityManagement file
/// </summary>
public partial interface IFacilityManagement
{
    #region "IFacilityManagement Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    Guid FacilityId { get; set; }

    /// <summary>
    /// Building Charter School Realty Access Type
    /// <para>
    /// The type of real estate vehicle through which a public charter school has access and control of its building space.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20846">Building Charter School Realty Access Type</a>
    /// </para>
    /// </summary>
    Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get; set; }

    /// <summary>
    /// Building Cleaning Standard Type
    /// <para>
    /// The standard for cleanliness, and benchmarks for how much space can be assigned to one properly supplied custodian to meet these standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20847">Building Cleaning Standard Type</a>
    /// </para>
    /// </summary>
    Guid? RefBuildingCleaningStandardTypeId { get; set; }

    /// <summary>
    /// Facility Capital Program Management Type
    /// <para>
    /// The type of management organization for planning, design, and construction of major capital projects.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20853">Facility Capital Program Management Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilityCapitalProgramMgmtTypeId { get; set; }

    /// <summary>
    /// Facility Compliance Agency Type
    /// <para>
    /// The type of agency that has ultimate responsibility for the compliance determination.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20848">Facility Compliance Agency Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilityComplianceAgencyTypeId { get; set; }

    /// <summary>
    /// Facility Operations Management Type
    /// <para>
    /// The type of management arrangements whereby a district oversees and manages its facilities operations.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20854">Facility Operations Management Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilityOperationsMgmtTypeId { get; set; }

    #endregion
}
