//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12leaSafeDrugFree.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaSafeDrugFree file
/// </summary>
public partial interface IK12leaSafeDrugFree
{
    #region "IK12leaSafeDrugFree Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String Baseline { get; set; }

    System.String BaselineYear { get; set; }

    System.String CollectionFrequency { get; set; }

    System.String IndicatorName { get; set; }

    System.String Instrument { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    Guid K12leaId { get; set; }

    System.String MostRecentCollection { get; set; }

    System.String Performance { get; set; }

    System.String Target { get; set; }

    #endregion
}
