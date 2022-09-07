//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElclassSectionServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElclassSectionService file
/// </summary>
public partial class ElclassSectionServiceModel : AutobahnBaseModel, IElclassSectionService
{
    #region "IElclassSectionService Properties"
    public System.String ElclassGroupCurriculumType { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IElclassSection"/> model
    /// </summary>
    public Guid ElclassSectionId { get; set; }

    public Int32? OldestAgeServed { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElgroupSizeStandardMet"/> model
    /// </summary>
    public Guid? RefElgroupSizeStandardMetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFrequencyOfService"/> model
    /// </summary>
    public Guid? RefFrequencyOfServiceId { get; set; }

    public Boolean? ServesChildrenWithSpecialNeeds { get; set; }

    public Int32? YoungestAgeServed { get; set; }

    #endregion
}
