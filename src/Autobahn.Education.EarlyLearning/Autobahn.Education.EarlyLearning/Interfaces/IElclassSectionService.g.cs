//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IElclassSectionService.g.cs
//***************************************************************************

/// <summary>
/// The IElclassSectionService file
/// </summary>
public partial interface IElclassSectionService
{
    #region "IElclassSectionService Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String ElclassGroupCurriculumType { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IElclassSection"/> model
    /// </summary>
    Guid ElclassSectionId { get; set; }

    Int32? OldestAgeServed { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElgroupSizeStandardMet"/> model
    /// </summary>
    Guid? RefElgroupSizeStandardMetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFrequencyOfService"/> model
    /// </summary>
    Guid? RefFrequencyOfServiceId { get; set; }

    Boolean? ServesChildrenWithSpecialNeeds { get; set; }

    Int32? YoungestAgeServed { get; set; }

    #endregion
}
