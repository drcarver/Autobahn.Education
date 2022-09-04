//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignConstructionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityDesignConstruction file
/// </summary>
[Table("FacilityDesignConstruction", Schema = "Facilities")]
public partial class FacilityDesignConstructionEntity : EntityBase, IFacilityDesignConstruction
{
    #region "IFacilityDesignConstruction Properties"
    /// <summary>
    /// Building Addition Code
    /// <para>
    /// A unique number or alphanumeric code assigned to a building addition by a school, school system, state, or other agency or entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20757">Building Addition Code</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A unique number or alphanumeric code assigned to a building addition by a school, school system, state, or other agency or entity.")]
    public System.String BuildingAdditionCode { get; set; }

    /// <summary>
    /// Building Addition Description
    /// <para>
    /// A description of the permanent structure added to the original building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20756">Building Addition Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A description of the permanent structure added to the original building.")]
    public System.String BuildingAdditionDescription { get; set; }

    /// <summary>
    /// Building Site Improvement Description
    /// <para>
    /// A description of the designed and constructed improvements made to a site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20831">Building Site Improvement Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A description of the designed and constructed improvements made to a site.")]
    public System.String BuildingSiteImprovementDescription { get; set; }

    /// <summary>
    /// Facility Addition Year
    /// <para>
    /// The year the construction on the addition was completed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20750">Facility Addition Year</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The year the construction on the addition was completed.")]
    public System.String FacilityAdditionYear { get; set; }

    /// <summary>
    /// Facility Construction Date
    /// <para>
    /// The month, day, and year on which construction of a building, addition, or improvement was completed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20761">Facility Construction Date</a>
    /// </para>
    /// </summary>
    [Comment("The month, day, and year on which construction of a building, addition, or improvement was completed.")]
    public DateTime? FacilityConstructionDate { get; set; }

    /// <summary>
    /// Facility Construction Year
    /// <para>
    /// The year the building was first constructed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20752">Facility Construction Year</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The year the building was first constructed.")]
    public System.String FacilityConstructionYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityDesign"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("FacilityDesign")]
    public Guid FacilityDesignId { get; set; }

    /// <summary>
    /// Building Energy Conservation Measure Type
    /// <para>
    /// The type of modification to, or replacement of, a piece of equipment or building shell/system that increases energy efficiency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20849">Building Energy Conservation Measure Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingEnergyConservationMeasureType")]
    [Comment("The type of modification to, or replacement of, a piece of equipment or building shell/system that increases energy efficiency.")]
    public Guid? RefBuildingEnergyConservationMeasureTypeId { get; set; }

    /// <summary>
    /// Facility Construction Date Type
    /// <para>
    /// Designation of the nature of the construction completion date.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20762">Facility Construction Date Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityConstructionDateType")]
    [Comment("Designation of the nature of the construction completion date.")]
    public Guid? RefFacilityConstructionDateTypeId { get; set; }

    /// <summary>
    /// Facility Construction Material Type
    /// <para>
    /// The primary material used for the construction of a building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20763">Facility Construction Material Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityConstructionMaterialType")]
    [Comment("The primary material used for the construction of a building.")]
    public Guid? RefFacilityConstructionMaterialTypeId { get; set; }

    /// <summary>
    /// Facility Joint Development Type
    /// <para>
    /// The type of development where two or more entities partner to plan, site, design, and/or build a new school or renovate an existing school to better support the joint use of the building and/or land.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20856">Facility Joint Development Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityJointDevelopmentType")]
    [Comment("The type of development where two or more entities partner to plan, site, design, and/or build a new school or renovate an existing school to better support the joint use of the building and/or land.")]
    public Guid? RefFacilityJointDevelopmentTypeId { get; set; }

    /// <summary>
    /// Facility Site Improvement Location Type
    /// <para>
    /// The type of location of the designed and constructed improvements made to a site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20768">Facility Site Improvement Location Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilitySiteImprovementLocationType")]
    [Comment("The type of location of the designed and constructed improvements made to a site.")]
    public Guid? RefFacilitySiteImprovementLocationTypeId { get; set; }

    /// <summary>
    /// Facility Standard Type
    /// <para>
    /// An indication of the district or state requirements or guidelines for the design and construction of school facilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20865">Facility Standard Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityStandardType")]
    [Comment("An indication of the district or state requirements or guidelines for the design and construction of school facilities.")]
    public Guid? RefFacilityStandardTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityDesign"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityDesignEntity FacilityDesignEntity { get; set; }

    /// <summary>
    /// The type of modification to, or replacement of, a piece of equipment or building shell/system that increases energy efficiency.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20849">Building Energy Conservation Measure Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefBuildingEnergyConservationMeasureTypeEntity? RefBuildingEnergyConservationMeasureTypeEntity { get; set; }

    /// <summary>
    /// Designation of the nature of the construction completion date.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20762">Facility Construction Date Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityConstructionDateTypeEntity? RefFacilityConstructionDateTypeEntity { get; set; }

    /// <summary>
    /// The primary material used for the construction of a building.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20763">Facility Construction Material Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityConstructionMaterialTypeEntity? RefFacilityConstructionMaterialTypeEntity { get; set; }

    /// <summary>
    /// The type of development where two or more entities partner to plan, site, design, and/or build a new school or renovate an existing school to better support the joint use of the building and/or land.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20856">Facility Joint Development Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityJointDevelopmentTypeEntity? RefFacilityJointDevelopmentTypeEntity { get; set; }

    /// <summary>
    /// The type of location of the designed and constructed improvements made to a site.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20768">Facility Site Improvement Location Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilitySiteImprovementLocationTypeEntity? RefFacilitySiteImprovementLocationTypeEntity { get; set; }

    /// <summary>
    /// An indication of the district or state requirements or guidelines for the design and construction of school facilities.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20865">Facility Standard Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityStandardTypeEntity? RefFacilityStandardTypeEntity { get; set; }

    #endregion
}
