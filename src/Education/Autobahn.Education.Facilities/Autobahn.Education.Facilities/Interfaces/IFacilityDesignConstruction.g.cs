//***************************************************************************
//* DomainName: Facilities
//* FileName:   IFacilityDesignConstruction.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityDesignConstruction file
/// </summary>
public partial interface IFacilityDesignConstruction
{
    #region "IFacilityDesignConstruction Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Building Addition Code
    /// <para>
    /// A unique number or alphanumeric code assigned to a building addition by a school, school system, state, or other agency or entity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20757">Building Addition Code</a>
    /// </para>
    /// </summary>
    System.String BuildingAdditionCode { get; set; }

    /// <summary>
    /// Building Addition Description
    /// <para>
    /// A description of the permanent structure added to the original building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20756">Building Addition Description</a>
    /// </para>
    /// </summary>
    System.String BuildingAdditionDescription { get; set; }

    /// <summary>
    /// Building Site Improvement Description
    /// <para>
    /// A description of the designed and constructed improvements made to a site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20831">Building Site Improvement Description</a>
    /// </para>
    /// </summary>
    System.String BuildingSiteImprovementDescription { get; set; }

    /// <summary>
    /// Facility Addition Year
    /// <para>
    /// The year the construction on the addition was completed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20750">Facility Addition Year</a>
    /// </para>
    /// </summary>
    System.String FacilityAdditionYear { get; set; }

    /// <summary>
    /// Facility Construction Date
    /// <para>
    /// The month, day, and year on which construction of a building, addition, or improvement was completed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20761">Facility Construction Date</a>
    /// </para>
    /// </summary>
    DateTime? FacilityConstructionDate { get; set; }

    /// <summary>
    /// Facility Construction Year
    /// <para>
    /// The year the building was first constructed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20752">Facility Construction Year</a>
    /// </para>
    /// </summary>
    System.String FacilityConstructionYear { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityDesign"/> model
    /// </summary>
    Guid FacilityDesignId { get; set; }

    /// <summary>
    /// Building Energy Conservation Measure Type
    /// <para>
    /// The type of modification to, or replacement of, a piece of equipment or building shell/system that increases energy efficiency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20849">Building Energy Conservation Measure Type</a>
    /// </para>
    /// </summary>
    Guid? RefBuildingEnergyConservationMeasureTypeId { get; set; }

    /// <summary>
    /// Facility Construction Date Type
    /// <para>
    /// Designation of the nature of the construction completion date.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20762">Facility Construction Date Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilityConstructionDateTypeId { get; set; }

    /// <summary>
    /// Facility Construction Material Type
    /// <para>
    /// The primary material used for the construction of a building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20763">Facility Construction Material Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilityConstructionMaterialTypeId { get; set; }

    /// <summary>
    /// Facility Joint Development Type
    /// <para>
    /// The type of development where two or more entities partner to plan, site, design, and/or build a new school or renovate an existing school to better support the joint use of the building and/or land.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20856">Facility Joint Development Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilityJointDevelopmentTypeId { get; set; }

    /// <summary>
    /// Facility Site Improvement Location Type
    /// <para>
    /// The type of location of the designed and constructed improvements made to a site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20768">Facility Site Improvement Location Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilitySiteImprovementLocationTypeId { get; set; }

    /// <summary>
    /// Facility Standard Type
    /// <para>
    /// An indication of the district or state requirements or guidelines for the design and construction of school facilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20865">Facility Standard Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilityStandardTypeId { get; set; }

    #endregion
}
