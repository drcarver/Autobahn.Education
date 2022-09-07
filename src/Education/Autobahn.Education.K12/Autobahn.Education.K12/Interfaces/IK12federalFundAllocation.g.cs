//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12federalFundAllocation.g.cs
//***************************************************************************

/// <summary>
/// The IK12federalFundAllocation file
/// </summary>
public partial interface IK12federalFundAllocation
{
    #region "IK12federalFundAllocation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String FederalProgramCode { get; set; }

    Decimal? FederalProgramsFundingAllocation { get; set; }

    Decimal? FundsTransferAmount { get; set; }

    Boolean? LeaTransferabilityOfFunds { get; set; }

    Int32? NumberOfImmigrantProgramSubgrants { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
    /// </summary>
    Guid OrganizationCalendarSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFederalProgramFundingAllocationType"/> model
    /// </summary>
    Guid? RefFederalProgramFundingAllocationTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLeaFundsTransferType"/> model
    /// </summary>
    Guid? RefLeaFundsTransferTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefReapAlternativeFundingStatus"/> model
    /// </summary>
    Guid? RefReapAlternativeFundingStatusId { get; set; }

    Decimal? SchoolImprovementAllocation { get; set; }

    Decimal? SchoolImprovementReservedPercent { get; set; }

    Decimal? SesPerPupilExpenditure { get; set; }

    #endregion
}
