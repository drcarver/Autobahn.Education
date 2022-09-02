//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityDesign file
/// </summary>
[Table("FacilityDesign", Schema = "Facilities")]
public partial class FacilityDesignEntity : EntityBase, IFacilityDesign
{
    #region "IFacilityDesign Properties"
    /// <summary>
    /// Building Architect Name
    /// <para>
    /// The name of the architect of record for the building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20815">Building Architect Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(45,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the architect of record for the building.")]
    public System.String BuildingArchitectName { get; set; }

    /// <summary>
    /// Building Architectural Firm Name
    /// <para>
    /// The name of the architectural firm responsible for the building design.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20816">Building Architectural Firm Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the architectural firm responsible for the building design.")]
    public System.String BuildingArchitecturalFirmName { get; set; }

    /// <summary>
    /// Building Date of Certificate of Occupancy
    /// <para>
    /// The month, day and year in which a certificate of occupancy was granted by the appropriate local authority.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20861">Building Date of Certificate of Occupancy</a>
    /// </para>
    /// </summary>
    [Comment("The month, day and year in which a certificate of occupancy was granted by the appropriate local authority.")]
    public DateTime? BuildingDateOfCertificateOfOccupancy { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Building Design Type
    /// <para>
    /// The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20797">Building Design Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingDesignType")]
    [Comment("The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.")]
    public Guid? RefBuildingDesignTypeId { get; set; }

    /// <summary>
    /// Building Environmental or Energy Performance Rating Category
    /// <para>
    /// The primary groupings that rating organizations use to evaluate environmental sustainability and energy use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20800">Building Environmental or Energy Performance Rating Category</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingEnvOrEnergyPerformanceRatingCat")]
    [Comment("The primary groupings that rating organizations use to evaluate environmental sustainability and energy use.")]
    public Guid? RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityEntity FacilityEntity { get; set; }

    /// <summary>
    /// The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20797">Building Design Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingDesignTypeEntity RefBuildingDesignTypeEntity { get; set; }

    /// <summary>
    /// The primary groupings that rating organizations use to evaluate environmental sustainability and energy use.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20800">Building Environmental or Energy Performance Rating Category</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingEnvOrEnergyPerformanceRatingCatEntity RefBuildingEnvOrEnergyPerformanceRatingCatEntity { get; set; }

    #endregion
}
