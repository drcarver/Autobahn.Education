//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaSafeDrugFreeEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaSafeDrugFree file
/// </summary>
public partial class K12leaSafeDrugFreeModel : AutobahnBaseModel, IK12leaSafeDrugFree
{
    #region "IK12leaSafeDrugFree Properties"
    public System.String Baseline { get; set; }

    public System.String BaselineYear { get; set; }

    public System.String CollectionFrequency { get; set; }

    public System.String IndicatorName { get; set; }

    public System.String Instrument { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    public Guid K12leaId { get; set; }

    public System.String MostRecentCollection { get; set; }

    public System.String Performance { get; set; }

    public System.String Target { get; set; }

    #endregion
}
