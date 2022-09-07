//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolImprovementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolImprovement file
/// </summary>
public partial class K12schoolImprovementModel : AutobahnBaseModel, IK12schoolImprovement
{
    #region "IK12schoolImprovement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    public Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementFunds"/> model
    /// </summary>
    public Guid? RefSchoolImprovementFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
    /// </summary>
    public Guid? RefSchoolImprovementStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSigInterventionType"/> model
    /// </summary>
    public Guid? RefSigInterventionTypeId { get; set; }

    public DateTime? SchoolImprovementExitDate { get; set; }

    #endregion
}
