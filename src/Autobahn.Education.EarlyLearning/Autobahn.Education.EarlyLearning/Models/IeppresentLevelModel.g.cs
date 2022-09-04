//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IeppresentLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIeppresentLevel file
/// </summary>
public partial class IeppresentLevelModel : AutobahnBaseModel, IIeppresentLevel
{
    #region "IIeppresentLevel Properties"
    public System.String AcademicDescription { get; set; }

    public System.String FunctionalDescription { get; set; }

    public System.String GeneralEducationDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
    /// </summary>
    public Guid IndividualizedProgramId { get; set; }

    public System.String ParentConcernDescription { get; set; }

    public System.String PreschoolDescription { get; set; }

    public System.String StudentConcernDescription { get; set; }

    public System.String StudentStrengthsDescription { get; set; }

    #endregion
}
