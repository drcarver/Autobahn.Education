//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12schoolImprovement.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolImprovement file
/// </summary>
public partial interface IK12schoolImprovement
{
    #region "IK12schoolImprovement Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementFunds"/> model
    /// </summary>
    Guid? RefSchoolImprovementFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
    /// </summary>
    Guid? RefSchoolImprovementStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSigInterventionType"/> model
    /// </summary>
    Guid? RefSigInterventionTypeId { get; set; }

    DateTime? SchoolImprovementExitDate { get; set; }

    #endregion
}
