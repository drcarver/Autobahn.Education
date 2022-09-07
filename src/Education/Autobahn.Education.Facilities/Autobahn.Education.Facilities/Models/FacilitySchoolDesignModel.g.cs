//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilitySchoolDesignEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilitySchoolDesign file
/// </summary>
public partial class FacilitySchoolDesignModel : AutobahnBaseModel, IFacilitySchoolDesign
{
    #region "IFacilitySchoolDesign Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityDesign"/> model
    /// </summary>
    public Guid FacilityDesignId { get; set; }

    /// <summary>
    /// Building School Design Type
    /// <para>
    /// The physical layout and character of a school facility, as determined by age groups served and educational programs provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20809">Building School Design Type</a>
    /// </para>
    /// </summary>
    public Guid RefBuildingSchoolDesignTypeId { get; set; }

    #endregion
}
