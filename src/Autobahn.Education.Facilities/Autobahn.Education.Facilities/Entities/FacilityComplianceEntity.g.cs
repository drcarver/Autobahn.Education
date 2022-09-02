//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityComplianceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityCompliance file
/// </summary>
[Table("FacilityCompliance", Schema = "Facilities")]
public partial class FacilityComplianceEntity : EntityBase, IFacilityCompliance
{
    #region "IFacilityCompliance Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> model
    /// </summary>
    [ForeignKey("BuildingSystemComponent")]
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
    [Comment("The month, day, and year that the condition of a system, component, equipment, or fixture was  checked.")]
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
    [Comment("The month, day, and year that the school, building, site, system, component, equipment, or fixture compliance status was determined.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the inspection or process that indicates conformity to the requirements or standards specified in federal, state, or local standards or codes.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A description of the component, system, or finish that needs replacement, repair, or maintenance to perform at an optimal level.")]
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
    [Comment("The estimated cost to bring systems, components, finishes, fixtures, or equipment to a state of good repair.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(35,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The description of a meaningful raw score of statistical expression of the performance on an inspection.")]
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
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A description of the standard violation(s) found in the inspection.")]
    public System.String FacilityInspectionViolationDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMandate"/> model
    /// </summary>
    [ForeignKey("FacilityMandate")]
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
    [ForeignKey("RefFacilityComplianceStatus")]
    [Comment("An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.")]
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
    [ForeignKey("RefFacilityMaintStandardType")]
    [Comment("The standard for maintenance of a component, system, or building.")]
    public Guid? RefFacilityMaintStandardTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMandate"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityMandateEntity FacilityMandateEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual BuildingSystemComponentEntity BuildingSystemComponentEntity { get; set; }

    /// <summary>
    /// An indication of whether the school, building, site, system, component, equipment, vehicle, or fixture conforms to the requirements or standards specified in federal, state, or local standards or codes or other officially required guidelines or regulations.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20773">Facility Compliance Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityComplianceStatusEntity RefFacilityComplianceStatusEntity { get; set; }

    /// <summary>
    /// The standard for maintenance of a component, system, or building.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20857">Facility Maintenance Standard Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityMaintStandardTypeEntity RefFacilityMaintStandardTypeEntity { get; set; }

    #endregion
}
