//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityComplianceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityCompliance file
/// </summary>
public partial class FacilityComplianceModel : AutobahnBaseModel, IFacilityCompliance
{
    #region "IFacilityCompliance Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> model
    /// </summary>
    public Guid? BuildingSystemComponentId { get; set; }

    /// <summary>
    /// Component or Fixture Check Date
    /// <para>
    /// The month, day, and year that the condition of a system, component, equipment, or fixture was  checked.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20879">Component or Fixture Check Date</a>
    /// </para>
    /// </summary>
    public DateTime? ComponentOrFixtureCheckDate { get; set; }

    /// <summary>
    /// Facility Compliance Determination Date
    /// <para>
    /// The month, day, and year that the school, building, site, system, component, equipment, or fixture compliance status was determined.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20818">Facility Compliance Determination Date</a>
    /// </para>
    /// </summary>
    public DateTime? FacilityComplianceDeterminationDate { get; set; }

    /// <summary>
    /// Facility Compliance Name
    /// <para>
    /// The name of the inspection or process that indicates conformity to the requirements or standards specified in federal, state, or local standards or codes.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20819">Facility Compliance Name</a>
    /// </para>
    /// </summary>
    public System.String FacilityComplianceName { get; set; }

    /// <summary>
    /// Facility Component Deficiency Description
    /// <para>
    /// A description of the component, system, or finish that needs replacement, repair, or maintenance to perform at an optimal level.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20820">Facility Component Deficiency Description</a>
    /// </para>
    /// </summary>
    public System.String FacilityComponentDeficiencyDescription { get; set; }

    /// <summary>
    /// Facility Estimated Cost to Eliminate Deferred Maintenance
    /// <para>
    /// The estimated cost to bring systems, components, finishes, fixtures, or equipment to a state of good repair.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20822">Facility Estimated Cost to Eliminate Deferred Maintenance</a>
    /// </para>
    /// </summary>
    public Decimal? FacilityEstimatedCostToEliminateDeferredMaint { get; set; }

    /// <summary>
    /// Facility Inspection Score Result Description
    /// <para>
    /// The description of a meaningful raw score of statistical expression of the performance on an inspection.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20827">Facility Inspection Score Result Description</a>
    /// </para>
    /// </summary>
    public System.String FacilityInspectionScoreResultDescription { get; set; }

    /// <summary>
    /// Facility Inspection Violation Description
    /// <para>
    /// A description of the standard violation(s) found in the inspection.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20828">Facility Inspection Violation Description</a>
    /// </para>
    /// </summary>
    public System.String FacilityInspectionViolationDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMandate"/> model
    /// </summary>
    public Guid? FacilityMandateId { get; set; }

    /// <summary>
    /// Facility Compliance Status
    /// <para>
    /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20773">Facility Compliance Status</a>
    /// </para>
    /// </summary>
    public Guid? RefFacilityComplianceStatusId { get; set; }

    /// <summary>
    /// Facility Maintenance Standard Type
    /// <para>
    /// The standard for maintenance of a component, system, or building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20857">Facility Maintenance Standard Type</a>
    /// </para>
    /// </summary>
    public Guid? RefFacilityMaintStandardTypeId { get; set; }

    #endregion
}
